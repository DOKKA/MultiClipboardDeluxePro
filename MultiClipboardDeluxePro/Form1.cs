﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;
using ScintillaNET.Demo.Utils;
using System.IO;
using MultiClipboardDeluxePro.Data;

namespace MultiClipboardDeluxePro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Scintilla TextArea;
        ClipService _clipService;

        bool IsMCDPSet = false;
        bool IsDisabled = false;
        private string Default_Font = "Consolas";
        string lastClipboardText;
        StringBuilder sb1 = new StringBuilder();

        private void MainForm_Load(object sender, EventArgs e)
        {
            lastClipboardText = Clipboard.GetText();
            //I'm opinionated about fonts...
            if (IsFontInstalled("Source Code Pro"))
            {
                Default_Font = "Source Code Pro";
            }

            SplitPanel.BringToFront();
            // CREATE CONTROL
            TextArea = new ScintillaNET.Scintilla();
            SplitPanel.Panel2.Controls.Add(TextArea);


            // BASIC CONFIG
            ClipTitle.Dock = DockStyle.Top;
            TextArea.Dock = DockStyle.Fill;
            TextArea.BringToFront();


            TextArea.TextChanged += (this.OnTextChanged);
            TextArea.LostFocus += (this.OnLostFocus);

            

            // INITIAL VIEW CONFIG
            TextArea.WrapMode = WrapMode.None;
            TextArea.IndentationGuides = IndentView.LookBoth;
            TextArea.MarginClick += TextArea_MarginClick;

            SetSyntaxHilighting("C#");

            // DRAG DROP
            InitDragDropFile();

            // INIT HOTKEYS
            InitHotkeys();
            Utils.ClipboardNotification.ClipboardUpdate += ClipboardNotification_ClipboardUpdate;

            _clipService = new ClipService(new DBContext());

            var clips = _clipService.GetList();
            foreach(var clip in clips)
            {
                ClipList.Rows.Insert(0, clip);
            }
            //IsStartup = false;
            ClipList.Rows[0].Selected = true;
        }

        private void ClipboardNotification_ClipboardUpdate(object sender, EventArgs e)
        {
            //var x = Clipboard.GetDataObject().GetData(DataFormats.OemText);
            //DataFormats.
            //debounce the windows clipboard event
            string text = Clipboard.GetText(TextDataFormat.UnicodeText);
            
            if(Clipboard.ContainsText(TextDataFormat.UnicodeText) && text != lastClipboardText)
            {
                ClipboardChanged();
                lastClipboardText = text;
            }
        }

        private void ClipboardChanged()
        {
            //change this to unicode only?
            string clipboardText = Clipboard.GetText(TextDataFormat.UnicodeText);
            //only add new clip if the type is text and the program isn't setting the clipboard
            //and it's actually has value
            if (!IsMCDPSet && !IsDisabled && !String.IsNullOrEmpty(clipboardText) && !ClipList.Focused)
            {

                var clip = new Clip()
                {
                    Data = clipboardText,
                    Title = "Untitled",
                    Timestamp = DateTime.Now,
                    Type = "C#"
                };

                _clipService.Create(clip);

                ClipList.Rows.Insert(0, new string[] { clip.ID.ToString(), clip.Title, clip.Timestamp.ToString("G"), clip.Type });
                TextArea.Text = clipboardText;
                ClipList.Rows[0].Selected = true;
            }
            IsMCDPSet = false;
        }

        private void ClipList_SelectionChanged(object sender, EventArgs e)
        {
            //only run this if there is another row, and if window is active
            //this way, the clipboard metadata is not immediately erased
            if (ClipList.RowCount > 0 && MainForm.ActiveForm != null)
            {
                var Clip = _clipService.Get(GetSelectedClipID());
                IsMCDPSet = true;
                TextArea.Text = Clip.Data;
                SetSyntaxHilighting(Clip.Type);
                ClipTitle.Text = Clip.Title;
                if(!String.IsNullOrEmpty(Clip.Data))
                {
                    Clipboard.SetText(Clip.Data, TextDataFormat.UnicodeText);
                }
                
            }
        }

        private void ClipList_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            _clipService.Delete(GetSelectedClipID());
        }

        private void ClipTitle_KeyUp(object sender, KeyEventArgs e)
        {
            if (ClipList.RowCount > 0)
            {
                ClipList.SelectedRows[0].Cells["Title"].Value = ClipTitle.Text;
            }
        }

        private void ClipTitle_Leave(object sender, EventArgs e)
        {
            if (ClipList.RowCount > 0)
            {
                ClipList.SelectedRows[0].Cells["Title"].Value = ClipTitle.Text;
                _clipService.UpdateTitle(GetSelectedClipID(), ClipTitle.Text);
            }
        }

        private void ClipType_Leave(object sender, EventArgs e)
        {
            if (ClipList.RowCount > 0)
            {
                ClipList.SelectedRows[0].Cells["Type"].Value = ClipType.Text;
                _clipService.UpdateType(GetSelectedClipID(), ClipType.Text);
            }
        }

        private void ClipType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSyntaxHilighting(ClipType.Text);
        }

        private void SetSyntaxHilighting(string Type)
        {
            InitColors();

            if (Type == "XML" || Type == "HTML")
            {
                InitSyntaxColoringXML();
            }
            else
            {
                InitSyntaxColoring();
            }

            if(Type == "C#")
            {
                TextArea.SetKeywords(0, "class extends implements import interface new case do while else if for in switch throw get set function var try catch finally while with default break continue delete return each const namespace package include use is as instanceof typeof author copy default deprecated eventType example exampleText exception haxe inheritDoc internal link mtasc mxmlc param private return see serial serialData serialField since throws usage version langversion playerversion productversion dynamic private public partial static intrinsic internal native override protected AS3 final super this arguments null Infinity NaN undefined true false abstract as base bool break by byte case catch char checked class const continue decimal default delegate do double descending explicit event extern else enum false finally fixed float for foreach from goto group if implicit in int interface internal into is lock long new null namespace object operator out override orderby params private protected public readonly ref return switch struct sbyte sealed short sizeof stackalloc static string select this throw true try typeof uint ulong unchecked unsafe ushort using var virtual volatile void while where yield");
                TextArea.SetKeywords(1, "void Null ArgumentError arguments Array Boolean Class Date DefinitionError Error EvalError Function int Math Namespace Number Object RangeError ReferenceError RegExp SecurityError String SyntaxError TypeError uint XML XMLList Boolean Byte Char DateTime Decimal Double Int16 Int32 Int64 IntPtr SByte Single UInt16 UInt32 UInt64 UIntPtr Void Path File System Windows Forms ScintillaNET");
            } else if( Type == "Javascript")
            {
                TextArea.SetKeywords(0, "abstract async await boolean break byte case catch char class const continue debugger default delete do double else enum export extends final finally float for from function goto if implements import in instanceof int interface let long native new null of package private protected public return short static super switch synchronized this throw throws transient try typeof var void volatile while with true false prototype yield");
            } else if(Type == "JSON")
            {
                TextArea.SetKeywords(0, "false null true");
            } 

            // NUMBER MARGIN
            InitNumberMargin();

            // BOOKMARK MARGIN
            InitBookmarkMargin();

            // CODE FOLDING MARGIN
            InitCodeFolding();

            if (Type == "XML" || Type == "HTML")
            {
                TextArea.SetProperty("fold.html", "1");
            }
            else
            {
                TextArea.SetProperty("fold.html", "0");
            }
            ClipType.Text = Type;
        }

        private void InitColors()
        {
            TextArea.SetSelectionBackColor(true, IntToColor(0x114D9C));
        }


		private void InitHotkeys() {

			// register the hotkeys with the form
			HotKeyManager.AddHotKey(this, OpenSearch, Keys.F, true);
			HotKeyManager.AddHotKey(this, OpenFindDialog, Keys.F, true, false, true);
			HotKeyManager.AddHotKey(this, OpenReplaceDialog, Keys.R, true);
			HotKeyManager.AddHotKey(this, OpenReplaceDialog, Keys.H, true);
			HotKeyManager.AddHotKey(this, Uppercase, Keys.U, true);
			HotKeyManager.AddHotKey(this, Lowercase, Keys.L, true);
			HotKeyManager.AddHotKey(this, ZoomIn, Keys.Oemplus, true);
			HotKeyManager.AddHotKey(this, ZoomOut, Keys.OemMinus, true);
			HotKeyManager.AddHotKey(this, ZoomDefault, Keys.D0, true);
			HotKeyManager.AddHotKey(this, CloseSearch, Keys.Escape);

			// remove conflicting hotkeys from scintilla
			TextArea.ClearCmdKey(Keys.Control | Keys.F);
			TextArea.ClearCmdKey(Keys.Control | Keys.R);
			TextArea.ClearCmdKey(Keys.Control | Keys.H);
			TextArea.ClearCmdKey(Keys.Control | Keys.L);
			TextArea.ClearCmdKey(Keys.Control | Keys.U);

		}

		private void InitSyntaxColoring() {

			// Configure the default style
			TextArea.StyleResetDefault();
			TextArea.Styles[Style.Default].Font = Default_Font;
			TextArea.Styles[Style.Default].Size = 10;
			TextArea.Styles[Style.Default].BackColor = IntToColor(0x212121);
			TextArea.Styles[Style.Default].ForeColor = IntToColor(0xFFFFFF);
            TextArea.CaretForeColor = IntToColor(0xFFFFFF);
			TextArea.StyleClearAll();

			// Configure the CPP (C#) lexer styles
			TextArea.Styles[Style.Cpp.Identifier].ForeColor = IntToColor(0xD0DAE2);
			TextArea.Styles[Style.Cpp.Comment].ForeColor = IntToColor(0xBD758B);
			TextArea.Styles[Style.Cpp.CommentLine].ForeColor = IntToColor(0x40BF57);
			TextArea.Styles[Style.Cpp.CommentDoc].ForeColor = IntToColor(0x2FAE35);
			TextArea.Styles[Style.Cpp.Number].ForeColor = IntToColor(0xFFFF00);
			TextArea.Styles[Style.Cpp.String].ForeColor = IntToColor(0xFFFF00);
			TextArea.Styles[Style.Cpp.Character].ForeColor = IntToColor(0xE95454);
			TextArea.Styles[Style.Cpp.Preprocessor].ForeColor = IntToColor(0x8AAFEE);
			TextArea.Styles[Style.Cpp.Operator].ForeColor = IntToColor(0xE0E0E0);
			TextArea.Styles[Style.Cpp.Regex].ForeColor = IntToColor(0xff00ff);
			TextArea.Styles[Style.Cpp.CommentLineDoc].ForeColor = IntToColor(0x77A7DB);
			TextArea.Styles[Style.Cpp.Word].ForeColor = IntToColor(0x48A8EE);
			TextArea.Styles[Style.Cpp.Word2].ForeColor = IntToColor(0xF98906);
			TextArea.Styles[Style.Cpp.CommentDocKeyword].ForeColor = IntToColor(0xB3D991);
			TextArea.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = IntToColor(0xFF0000);
			TextArea.Styles[Style.Cpp.GlobalClass].ForeColor = IntToColor(0x48A8EE);

			TextArea.Lexer = Lexer.Cpp;


            //TextArea.SetProperty("fold.html", "0");
        }

        private void InitSyntaxColoringXML()
        {
            // Configure the default style
            TextArea.StyleResetDefault();
            TextArea.Styles[Style.Default].Font = Default_Font;
            TextArea.Styles[Style.Default].Size = 10;
            TextArea.Styles[Style.Default].BackColor = IntToColor(0x212121);
            TextArea.Styles[Style.Default].ForeColor = IntToColor(0xFFFFFF);
            TextArea.CaretForeColor = IntToColor(0xFFFFFF);
            TextArea.StyleClearAll();

            TextArea.Styles[Style.Xml.Attribute].ForeColor = IntToColor(0xBEC89E);
            TextArea.Styles[Style.Xml.Entity].ForeColor = IntToColor(0xE3CEAB);
            TextArea.Styles[Style.Xml.Comment].ForeColor = IntToColor(0x7F9F7F);
            TextArea.Styles[Style.Xml.Tag].ForeColor = IntToColor(0xE3CEAB);
            TextArea.Styles[Style.Xml.TagEnd].ForeColor = IntToColor(0xE3CEAB);
            TextArea.Styles[Style.Xml.DoubleString].ForeColor = IntToColor(0xC89191);
            TextArea.Styles[Style.Xml.SingleString].ForeColor = IntToColor(0xC89191);

            TextArea.Lexer = Lexer.Html;
            //TextArea.SetProperty("fold.html", "1");
        }

		private void OnTextChanged(object sender, EventArgs e) {

		}

        private void OnLostFocus(object sender, EventArgs e)
        {
            if (ClipList.RowCount > 0)
            {
                _clipService.UpdateData(GetSelectedClipID(), TextArea.Text);
            }
        }
        


        #region Numbers, Bookmarks, Code Folding

        /// <summary>
        /// the background color of the text area
        /// </summary>
        private const int BACK_COLOR = 0x2A211C;

		/// <summary>
		/// default text color of the text area
		/// </summary>
		private const int FORE_COLOR = 0xB7B7B7;

		/// <summary>
		/// change this to whatever margin you want the line numbers to show in
		/// </summary>
		private const int NUMBER_MARGIN = 1;

		/// <summary>
		/// change this to whatever margin you want the bookmarks/breakpoints to show in
		/// </summary>
		private const int BOOKMARK_MARGIN = 2;
		private const int BOOKMARK_MARKER = 2;

		/// <summary>
		/// change this to whatever margin you want the code folding tree (+/-) to show in
		/// </summary>
		private const int FOLDING_MARGIN = 3;

		/// <summary>
		/// set this true to show circular buttons for code folding (the [+] and [-] buttons on the margin)
		/// </summary>
		private const bool CODEFOLDING_CIRCULAR = true;

		private void InitNumberMargin() {

			TextArea.Styles[Style.LineNumber].BackColor = IntToColor(BACK_COLOR);
			TextArea.Styles[Style.LineNumber].ForeColor = IntToColor(FORE_COLOR);
			TextArea.Styles[Style.IndentGuide].ForeColor = IntToColor(FORE_COLOR);
			TextArea.Styles[Style.IndentGuide].BackColor = IntToColor(BACK_COLOR);

			var nums = TextArea.Margins[NUMBER_MARGIN];
			nums.Width = 30;
			nums.Type = MarginType.Number;
			nums.Sensitive = true;
			nums.Mask = 0;


		}

		private void InitBookmarkMargin() {

			//TextArea.SetFoldMarginColor(true, IntToColor(BACK_COLOR));

			var margin = TextArea.Margins[BOOKMARK_MARGIN];
			margin.Width = 20;
			margin.Sensitive = true;
			margin.Type = MarginType.Symbol;
			margin.Mask = (1 << BOOKMARK_MARKER);
			//margin.Cursor = MarginCursor.Arrow;

			var marker = TextArea.Markers[BOOKMARK_MARKER];
			marker.Symbol = MarkerSymbol.Circle;
			marker.SetBackColor(IntToColor(0xFF003B));
			marker.SetForeColor(IntToColor(0x000000));
			marker.SetAlpha(100);

		}

		private void InitCodeFolding() {

			TextArea.SetFoldMarginColor(true, IntToColor(BACK_COLOR));
			TextArea.SetFoldMarginHighlightColor(true, IntToColor(BACK_COLOR));

			// Enable code folding
			TextArea.SetProperty("fold", "1");
			TextArea.SetProperty("fold.compact", "1");
            //TextArea.SetProperty("fold.html", "1");

            // Configure a margin to display folding symbols
            TextArea.Margins[FOLDING_MARGIN].Type = MarginType.Symbol;
			TextArea.Margins[FOLDING_MARGIN].Mask = Marker.MaskFolders;
			TextArea.Margins[FOLDING_MARGIN].Sensitive = true;
			TextArea.Margins[FOLDING_MARGIN].Width = 20;

			// Set colors for all folding markers
			for (int i = 25; i <= 31; i++) {
				TextArea.Markers[i].SetForeColor(IntToColor(BACK_COLOR)); // styles for [+] and [-]
				TextArea.Markers[i].SetBackColor(IntToColor(FORE_COLOR)); // styles for [+] and [-]
			}

			// Configure folding markers with respective symbols
			TextArea.Markers[Marker.Folder].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CirclePlus : MarkerSymbol.BoxPlus;
			TextArea.Markers[Marker.FolderOpen].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CircleMinus : MarkerSymbol.BoxMinus;
			TextArea.Markers[Marker.FolderEnd].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CirclePlusConnected : MarkerSymbol.BoxPlusConnected;
			TextArea.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
			TextArea.Markers[Marker.FolderOpenMid].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CircleMinusConnected : MarkerSymbol.BoxMinusConnected;
			TextArea.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
			TextArea.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

			// Enable automatic folding
			TextArea.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);

		}

		private void TextArea_MarginClick(object sender, MarginClickEventArgs e) {
			if (e.Margin == BOOKMARK_MARGIN) {
				// Do we have a marker for this line?
				const uint mask = (1 << BOOKMARK_MARKER);
				var line = TextArea.Lines[TextArea.LineFromPosition(e.Position)];
				if ((line.MarkerGet() & mask) > 0) {
					// Remove existing bookmark
					line.MarkerDelete(BOOKMARK_MARKER);
				} else {
					// Add bookmark
					line.MarkerAdd(BOOKMARK_MARKER);
				}
			}
		}

		#endregion

		#region Drag & Drop File

		public void InitDragDropFile() {

			TextArea.AllowDrop = true;
			TextArea.DragEnter += delegate(object sender, DragEventArgs e) {
				if (e.Data.GetDataPresent(DataFormats.FileDrop))
					e.Effect = DragDropEffects.Copy;
				else
					e.Effect = DragDropEffects.None;
			};
			TextArea.DragDrop += delegate(object sender, DragEventArgs e) {

				// get file drop
				if (e.Data.GetDataPresent(DataFormats.FileDrop)) {

					Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
					if (a != null) {

						string path = a.GetValue(0).ToString();

						LoadDataFromFile(path);

					}
				}
			};

		}

		private void LoadDataFromFile(string path) {
			if (File.Exists(path)) {
                if(ActiveForm != null)
                {
                    ActiveForm.Text = "ScintillaNET Demo App" + Path.GetFileName(path);
                }
                
				TextArea.Text = File.ReadAllText(path);
			}
		}

        #endregion

        #region Main Menu Commands

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e) {
			OpenSearch();
		}

		private void findDialogToolStripMenuItem_Click(object sender, EventArgs e) {
			OpenFindDialog();
		}

		private void findAndReplaceToolStripMenuItem_Click(object sender, EventArgs e) {
			OpenReplaceDialog();
		}

		private void cutToolStripMenuItem_Click(object sender, EventArgs e) {
			TextArea.Cut();
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
			TextArea.Copy();
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {
			TextArea.Paste();
		}

		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) {
			TextArea.SelectAll();
		}

		private void selectLineToolStripMenuItem_Click(object sender, EventArgs e) {
			Line line = TextArea.Lines[TextArea.CurrentLine];
			TextArea.SetSelection(line.Position + line.Length, line.Position);
		}

		private void clearSelectionToolStripMenuItem_Click(object sender, EventArgs e) {
			TextArea.SetEmptySelection(0);
		}

		private void indentSelectionToolStripMenuItem_Click(object sender, EventArgs e) {
			Indent();
		}

		private void outdentSelectionToolStripMenuItem_Click(object sender, EventArgs e) {
			Outdent();
		}

		private void uppercaseSelectionToolStripMenuItem_Click(object sender, EventArgs e) {
			Uppercase();
		}

		private void lowercaseSelectionToolStripMenuItem_Click(object sender, EventArgs e) {
			Lowercase();
		}

        private void beautifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Beautify("js");
        }

        private void htmlBeautifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Beautify("html");
        }

        private void cssBeautifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Beautify("css");
        }

        private void wordWrapToolStripMenuItem1_Click(object sender, EventArgs e) {

            // toggle word wrap
            wordWrapItem.Checked = !wordWrapItem.Checked;
            TextArea.WrapMode = wordWrapItem.Checked ? WrapMode.Word : WrapMode.None;
        }

        private void indentGuidesToolStripMenuItem_Click(object sender, EventArgs e) {

            // toggle indent guides
            indentGuidesItem.Checked = !indentGuidesItem.Checked;
            TextArea.IndentationGuides = indentGuidesItem.Checked ? IndentView.LookBoth : IndentView.None;
        }

        private void hiddenCharactersToolStripMenuItem_Click(object sender, EventArgs e) {
            // toggle view whitespace
            hiddenCharactersItem.Checked = !hiddenCharactersItem.Checked;
            TextArea.ViewWhitespace = hiddenCharactersItem.Checked ? WhitespaceMode.VisibleAlways : WhitespaceMode.Invisible;
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e) {
			ZoomIn();
		}

		private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e) {
			ZoomOut();
		}

		private void zoom100ToolStripMenuItem_Click(object sender, EventArgs e) {
			ZoomDefault();
		}

		private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e) {
			TextArea.FoldAll(FoldAction.Contract);
		}

		private void expandAllToolStripMenuItem_Click(object sender, EventArgs e) {
			TextArea.FoldAll(FoldAction.Expand);
		}

        private void toggleCollapseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!SplitPanel.Panel1Collapsed)
            {
                SplitPanel.Panel1Collapsed = true;
                toggleCollapseToolStripMenuItem.Text = @"[->]";
            } else
            {
                SplitPanel.Panel1Collapsed = false;
                toggleCollapseToolStripMenuItem.Text = @"[<-]";
            }

        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(disableToolStripMenuItem.Text == "RUNNING")
            {
                IsDisabled = true;
                disableToolStripMenuItem.Text = "STOPPED";
            } else
            {
                IsDisabled = false;
                disableToolStripMenuItem.Text = "RUNNING";
            }
        }


        #endregion

        #region Format

        private void Beautify(string type)
        {
            Utils.Beautifier b1 = new Utils.Beautifier(type, TextArea.Text);
            b1.handler += new EventHandler((oSender, eArgs) => {
                InvokeIfNeeded(() =>
                {
                    TextArea.Text = b1.sb1.ToString();
                });
            });

            b1.StartProcess();
        }


        #endregion


        #region Uppercase / Lowercase

        private void Lowercase() {

			// save the selection
			int start = TextArea.SelectionStart;
			int end = TextArea.SelectionEnd;

			// modify the selected text
			TextArea.ReplaceSelection(TextArea.GetTextRange(start, end - start).ToLower());

			// preserve the original selection
			TextArea.SetSelection(start, end);
		}

		private void Uppercase() {

			// save the selection
			int start = TextArea.SelectionStart;
			int end = TextArea.SelectionEnd;

			// modify the selected text
			TextArea.ReplaceSelection(TextArea.GetTextRange(start, end - start).ToUpper());

			// preserve the original selection
			TextArea.SetSelection(start, end);
		}

		#endregion

		#region Indent / Outdent

		private void Indent() {
			// we use this hack to send "Shift+Tab" to scintilla, since there is no known API to indent,
			// although the indentation function exists. Pressing TAB with the editor focused confirms this.
			GenerateKeystrokes("{TAB}");
		}

		private void Outdent() {
			// we use this hack to send "Shift+Tab" to scintilla, since there is no known API to outdent,
			// although the indentation function exists. Pressing Shift+Tab with the editor focused confirms this.
			GenerateKeystrokes("+{TAB}");
		}

		private void GenerateKeystrokes(string keys) {
			HotKeyManager.Enable = false;
			TextArea.Focus();
			SendKeys.Send(keys);
			HotKeyManager.Enable = true;
		}

		#endregion

		#region Zoom

		private void ZoomIn() {
			TextArea.ZoomIn();
		}

		private void ZoomOut() {
			TextArea.ZoomOut();
		}

		private void ZoomDefault() {
			TextArea.Zoom = 0;
		}


		#endregion

		#region Quick Search Bar

		bool SearchIsOpen = false;

		private void OpenSearch() {

			SearchManager.SearchBox = TxtSearch;
			SearchManager.TextArea = TextArea;

			if (!SearchIsOpen) {
				SearchIsOpen = true;
				InvokeIfNeeded(delegate() {
					PanelSearch.Visible = true;
                    PanelSearch.BringToFront();
					TxtSearch.Text = SearchManager.LastSearch;
					TxtSearch.Focus();
					TxtSearch.SelectAll();
				});
			} else {
				InvokeIfNeeded(delegate() {
					TxtSearch.Focus();
					TxtSearch.SelectAll();
				});
			}
		}
		private void CloseSearch() {
			if (SearchIsOpen) {
				SearchIsOpen = false;
				InvokeIfNeeded(delegate() {
					PanelSearch.Visible = false;
					//CurBrowser.GetBrowser().StopFinding(true);
				});
			}
		}

		private void BtnClearSearch_Click(object sender, EventArgs e) {
			CloseSearch();
		}

		private void BtnPrevSearch_Click(object sender, EventArgs e) {
			SearchManager.Find(false, false);
		}
		private void BtnNextSearch_Click(object sender, EventArgs e) {
			SearchManager.Find(true, false);
		}
		private void TxtSearch_TextChanged(object sender, EventArgs e) {
			SearchManager.Find(true, true);
		}

		private void TxtSearch_KeyDown(object sender, KeyEventArgs e) {
            if (HotKeyManager.IsHotkey(e, Keys.Enter))
            {
                SearchManager.Find(true, false);
            }
            if (HotKeyManager.IsHotkey(e, Keys.Enter, true) || HotKeyManager.IsHotkey(e, Keys.Enter, false, true))
            {
                SearchManager.Find(false, false);
            }
        }

        #endregion

        #region Find & Replace Dialog

        private void OpenFindDialog() {

		}
		private void OpenReplaceDialog() {


		}

		#endregion

		#region Utils

		public static Color IntToColor(int rgb) {
			return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
		}

        private bool IsFontInstalled(string fontName)
        {
            using (var testFont = new Font(fontName, 10))
            {
                return 0 == string.Compare(
                fontName,
                testFont.Name,
                StringComparison.InvariantCultureIgnoreCase);
            }
        }

        public void InvokeIfNeeded(Action action) {
			if (this.InvokeRequired) {
				this.BeginInvoke(action);
			} else {
				action.Invoke();
			}
		}



        private long GetSelectedClipID()
        {
            string strID = ClipList.SelectedRows[0].Cells[0].Value.ToString();
            return long.Parse(strID);
        }




        #endregion


    }
}
