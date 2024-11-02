namespace TryScript
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textScript = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.textCurrent = new System.Windows.Forms.TextBox();
            this.buttonFileList = new System.Windows.Forms.Button();
            this.panelCompose = new System.Windows.Forms.Panel();
            this.contextMenuStripCompose = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItemSaveMinWidth = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItemSaveMaxWidth = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItemSaveRatio = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUDLines = new System.Windows.Forms.NumericUpDown();
            this.numericUDLineFrom = new System.Windows.Forms.NumericUpDown();
            this.radioLineFind = new System.Windows.Forms.RadioButton();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUDSkips = new System.Windows.Forms.NumericUpDown();
            this.radioRegexFind = new System.Windows.Forms.RadioButton();
            this.radioNormalFind = new System.Windows.Forms.RadioButton();
            this.buttonCheckSelection = new System.Windows.Forms.Button();
            this.textFind = new System.Windows.Forms.TextBox();
            this.textEditDesc = new System.Windows.Forms.TextBox();
            this.buttonSavePrev = new System.Windows.Forms.Button();
            this.buttonSaveNext = new System.Windows.Forms.Button();
            this.radioScriptSize4 = new System.Windows.Forms.RadioButton();
            this.radioScriptSize3 = new System.Windows.Forms.RadioButton();
            this.radioScriptSize2 = new System.Windows.Forms.RadioButton();
            this.radioScriptSize1 = new System.Windows.Forms.RadioButton();
            this.radioScriptSize0 = new System.Windows.Forms.RadioButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.buttonNextDesc = new System.Windows.Forms.Button();
            this.buttonPrevDesc = new System.Windows.Forms.Button();
            this.buttonNextFile = new System.Windows.Forms.Button();
            this.buttonPrevFile = new System.Windows.Forms.Button();
            this.comboBoxFiles = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripCompose.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDLineFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDSkips)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textScript);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.textTotal);
            this.splitContainer1.Panel2.Controls.Add(this.textCurrent);
            this.splitContainer1.Panel2.Controls.Add(this.buttonFileList);
            this.splitContainer1.Panel2.Controls.Add(this.panelCompose);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.radioScriptSize4);
            this.splitContainer1.Panel2.Controls.Add(this.radioScriptSize3);
            this.splitContainer1.Panel2.Controls.Add(this.radioScriptSize2);
            this.splitContainer1.Panel2.Controls.Add(this.radioScriptSize1);
            this.splitContainer1.Panel2.Controls.Add(this.radioScriptSize0);
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonNextDesc);
            this.splitContainer1.Panel2.Controls.Add(this.buttonPrevDesc);
            this.splitContainer1.Panel2.Controls.Add(this.buttonNextFile);
            this.splitContainer1.Panel2.Controls.Add(this.buttonPrevFile);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxFiles);
            this.splitContainer1.Size = new System.Drawing.Size(740, 550);
            this.splitContainer1.SplitterDistance = 440;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            this.splitContainer1.Resize += new System.EventHandler(this.splitContainer1_Resize);
            // 
            // textScript
            // 
            this.textScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textScript.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textScript.HideSelection = false;
            this.textScript.Location = new System.Drawing.Point(3, 3);
            this.textScript.Multiline = true;
            this.textScript.Name = "textScript";
            this.textScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textScript.Size = new System.Drawing.Size(434, 544);
            this.textScript.TabIndex = 0;
            this.textScript.WordWrap = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "/";
            // 
            // textTotal
            // 
            this.textTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textTotal.Location = new System.Drawing.Point(132, 72);
            this.textTotal.Name = "textTotal";
            this.textTotal.ReadOnly = true;
            this.textTotal.Size = new System.Drawing.Size(39, 19);
            this.textTotal.TabIndex = 14;
            // 
            // textCurrent
            // 
            this.textCurrent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textCurrent.Location = new System.Drawing.Point(70, 72);
            this.textCurrent.Name = "textCurrent";
            this.textCurrent.ReadOnly = true;
            this.textCurrent.Size = new System.Drawing.Size(39, 19);
            this.textCurrent.TabIndex = 14;
            // 
            // buttonFileList
            // 
            this.buttonFileList.Location = new System.Drawing.Point(173, 5);
            this.buttonFileList.Name = "buttonFileList";
            this.buttonFileList.Size = new System.Drawing.Size(71, 23);
            this.buttonFileList.TabIndex = 13;
            this.buttonFileList.Text = "選択";
            this.buttonFileList.UseVisualStyleBackColor = true;
            this.buttonFileList.Click += new System.EventHandler(this.buttonFileList_Click);
            // 
            // panelCompose
            // 
            this.panelCompose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCompose.BackColor = System.Drawing.SystemColors.Control;
            this.panelCompose.ContextMenuStrip = this.contextMenuStripCompose;
            this.panelCompose.Location = new System.Drawing.Point(226, 0);
            this.panelCompose.Name = "panelCompose";
            this.panelCompose.Size = new System.Drawing.Size(40, 40);
            this.panelCompose.TabIndex = 12;
            this.panelCompose.DoubleClick += new System.EventHandler(this.panel2_DoubleClick);
            // 
            // contextMenuStripCompose
            // 
            this.contextMenuStripCompose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItemSaveMinWidth,
            this.contextMenuItemSaveMaxWidth,
            this.contextMenuItemSaveRatio,
            this.contextMenuItemNew});
            this.contextMenuStripCompose.Name = "contextMenuStrip1";
            this.contextMenuStripCompose.Size = new System.Drawing.Size(289, 92);
            this.contextMenuStripCompose.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripCompose_Opening);
            // 
            // contextMenuItemSaveMinWidth
            // 
            this.contextMenuItemSaveMinWidth.Name = "contextMenuItemSaveMinWidth";
            this.contextMenuItemSaveMinWidth.Size = new System.Drawing.Size(288, 22);
            this.contextMenuItemSaveMinWidth.Text = "現在のスプリッター左の幅を最小幅として保存";
            this.contextMenuItemSaveMinWidth.Click += new System.EventHandler(this.contextMenuItemSaveMinWidth_Click);
            // 
            // contextMenuItemSaveMaxWidth
            // 
            this.contextMenuItemSaveMaxWidth.Name = "contextMenuItemSaveMaxWidth";
            this.contextMenuItemSaveMaxWidth.Size = new System.Drawing.Size(288, 22);
            this.contextMenuItemSaveMaxWidth.Text = "現在のスプリッター左の幅を最大値として保存";
            this.contextMenuItemSaveMaxWidth.Click += new System.EventHandler(this.contextMenuItemSaveMaxWidth_Click);
            // 
            // contextMenuItemSaveRatio
            // 
            this.contextMenuItemSaveRatio.Name = "contextMenuItemSaveRatio";
            this.contextMenuItemSaveRatio.Size = new System.Drawing.Size(288, 22);
            this.contextMenuItemSaveRatio.Text = "現在にスプリッターの比率を保存";
            this.contextMenuItemSaveRatio.Click += new System.EventHandler(this.contextMenuItemSaveRatio_Click);
            // 
            // contextMenuItemNew
            // 
            this.contextMenuItemNew.Name = "contextMenuItemNew";
            this.contextMenuItemNew.Size = new System.Drawing.Size(288, 22);
            this.contextMenuItemNew.Text = "新規";
            this.contextMenuItemNew.Click += new System.EventHandler(this.contextMenuItemNew_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.numericUDLines);
            this.panel1.Controls.Add(this.numericUDLineFrom);
            this.panel1.Controls.Add(this.radioLineFind);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUDSkips);
            this.panel1.Controls.Add(this.radioRegexFind);
            this.panel1.Controls.Add(this.radioNormalFind);
            this.panel1.Controls.Add(this.buttonCheckSelection);
            this.panel1.Controls.Add(this.textFind);
            this.panel1.Controls.Add(this.textEditDesc);
            this.panel1.Controls.Add(this.buttonSavePrev);
            this.panel1.Controls.Add(this.buttonSaveNext);
            this.panel1.Location = new System.Drawing.Point(7, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 419);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            // 
            // numericUDLines
            // 
            this.numericUDLines.Location = new System.Drawing.Point(200, 72);
            this.numericUDLines.Name = "numericUDLines";
            this.numericUDLines.Size = new System.Drawing.Size(51, 19);
            this.numericUDLines.TabIndex = 12;
            this.numericUDLines.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUDLineFrom
            // 
            this.numericUDLineFrom.Location = new System.Drawing.Point(134, 72);
            this.numericUDLineFrom.Name = "numericUDLineFrom";
            this.numericUDLineFrom.Size = new System.Drawing.Size(60, 19);
            this.numericUDLineFrom.TabIndex = 12;
            this.numericUDLineFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioLineFind
            // 
            this.radioLineFind.AutoSize = true;
            this.radioLineFind.Location = new System.Drawing.Point(3, 72);
            this.radioLineFind.Name = "radioLineFind";
            this.radioLineFind.Size = new System.Drawing.Size(125, 16);
            this.radioLineFind.TabIndex = 11;
            this.radioLineFind.TabStop = true;
            this.radioLineFind.Text = "行指定（番号・行数）";
            this.radioLineFind.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonUpdate.Location = new System.Drawing.Point(72, 389);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(91, 23);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "更新";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "スキップ数";
            // 
            // numericUDSkips
            // 
            this.numericUDSkips.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUDSkips.Location = new System.Drawing.Point(145, 38);
            this.numericUDSkips.Name = "numericUDSkips";
            this.numericUDSkips.Size = new System.Drawing.Size(54, 19);
            this.numericUDSkips.TabIndex = 8;
            // 
            // radioRegexFind
            // 
            this.radioRegexFind.AutoSize = true;
            this.radioRegexFind.Location = new System.Drawing.Point(3, 50);
            this.radioRegexFind.Name = "radioRegexFind";
            this.radioRegexFind.Size = new System.Drawing.Size(71, 16);
            this.radioRegexFind.TabIndex = 7;
            this.radioRegexFind.TabStop = true;
            this.radioRegexFind.Text = "正規表現";
            this.radioRegexFind.UseVisualStyleBackColor = true;
            // 
            // radioNormalFind
            // 
            this.radioNormalFind.AutoSize = true;
            this.radioNormalFind.Location = new System.Drawing.Point(3, 28);
            this.radioNormalFind.Name = "radioNormalFind";
            this.radioNormalFind.Size = new System.Drawing.Size(83, 16);
            this.radioNormalFind.TabIndex = 6;
            this.radioNormalFind.TabStop = true;
            this.radioNormalFind.Text = "単純文字列";
            this.radioNormalFind.UseVisualStyleBackColor = true;
            // 
            // buttonCheckSelection
            // 
            this.buttonCheckSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheckSelection.Location = new System.Drawing.Point(60, 97);
            this.buttonCheckSelection.Name = "buttonCheckSelection";
            this.buttonCheckSelection.Size = new System.Drawing.Size(91, 23);
            this.buttonCheckSelection.TabIndex = 5;
            this.buttonCheckSelection.Text = "確認";
            this.buttonCheckSelection.UseVisualStyleBackColor = true;
            this.buttonCheckSelection.Click += new System.EventHandler(this.buttonCheckSelection_Click);
            // 
            // textFind
            // 
            this.textFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFind.Location = new System.Drawing.Point(3, 3);
            this.textFind.Name = "textFind";
            this.textFind.Size = new System.Drawing.Size(228, 19);
            this.textFind.TabIndex = 4;
            // 
            // textEditDesc
            // 
            this.textEditDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditDesc.Location = new System.Drawing.Point(3, 126);
            this.textEditDesc.Multiline = true;
            this.textEditDesc.Name = "textEditDesc";
            this.textEditDesc.Size = new System.Drawing.Size(228, 257);
            this.textEditDesc.TabIndex = 3;
            // 
            // buttonSavePrev
            // 
            this.buttonSavePrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSavePrev.Location = new System.Drawing.Point(3, 389);
            this.buttonSavePrev.Name = "buttonSavePrev";
            this.buttonSavePrev.Size = new System.Drawing.Size(76, 23);
            this.buttonSavePrev.TabIndex = 2;
            this.buttonSavePrev.Text = "前に追加";
            this.buttonSavePrev.UseVisualStyleBackColor = true;
            this.buttonSavePrev.Click += new System.EventHandler(this.buttonSavePrev_Click);
            // 
            // buttonSaveNext
            // 
            this.buttonSaveNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveNext.Location = new System.Drawing.Point(155, 389);
            this.buttonSaveNext.Name = "buttonSaveNext";
            this.buttonSaveNext.Size = new System.Drawing.Size(76, 23);
            this.buttonSaveNext.TabIndex = 1;
            this.buttonSaveNext.Text = "後に追加";
            this.buttonSaveNext.UseVisualStyleBackColor = true;
            this.buttonSaveNext.Click += new System.EventHandler(this.buttonSaveNext_Click);
            // 
            // radioScriptSize4
            // 
            this.radioScriptSize4.Location = new System.Drawing.Point(83, 4);
            this.radioScriptSize4.Name = "radioScriptSize4";
            this.radioScriptSize4.Size = new System.Drawing.Size(101, 24);
            this.radioScriptSize4.TabIndex = 10;
            this.radioScriptSize4.TabStop = true;
            this.radioScriptSize4.Text = "文字サイズ";
            this.radioScriptSize4.UseVisualStyleBackColor = true;
            this.radioScriptSize4.CheckedChanged += new System.EventHandler(this.radioScriptSize4_CheckedChanged);
            // 
            // radioScriptSize3
            // 
            this.radioScriptSize3.Location = new System.Drawing.Point(63, 4);
            this.radioScriptSize3.Name = "radioScriptSize3";
            this.radioScriptSize3.Size = new System.Drawing.Size(104, 24);
            this.radioScriptSize3.TabIndex = 9;
            this.radioScriptSize3.TabStop = true;
            this.radioScriptSize3.UseVisualStyleBackColor = true;
            this.radioScriptSize3.CheckedChanged += new System.EventHandler(this.radioScriptSize3_CheckedChanged);
            // 
            // radioScriptSize2
            // 
            this.radioScriptSize2.Location = new System.Drawing.Point(43, 4);
            this.radioScriptSize2.Name = "radioScriptSize2";
            this.radioScriptSize2.Size = new System.Drawing.Size(104, 24);
            this.radioScriptSize2.TabIndex = 8;
            this.radioScriptSize2.TabStop = true;
            this.radioScriptSize2.UseVisualStyleBackColor = true;
            this.radioScriptSize2.CheckedChanged += new System.EventHandler(this.radioScriptSize2_CheckedChanged);
            // 
            // radioScriptSize1
            // 
            this.radioScriptSize1.Location = new System.Drawing.Point(23, 4);
            this.radioScriptSize1.Name = "radioScriptSize1";
            this.radioScriptSize1.Size = new System.Drawing.Size(104, 24);
            this.radioScriptSize1.TabIndex = 7;
            this.radioScriptSize1.TabStop = true;
            this.radioScriptSize1.UseVisualStyleBackColor = true;
            this.radioScriptSize1.CheckedChanged += new System.EventHandler(this.radioScriptSize1_CheckedChanged);
            // 
            // radioScriptSize0
            // 
            this.radioScriptSize0.Location = new System.Drawing.Point(3, 4);
            this.radioScriptSize0.Name = "radioScriptSize0";
            this.radioScriptSize0.Size = new System.Drawing.Size(104, 24);
            this.radioScriptSize0.TabIndex = 6;
            this.radioScriptSize0.TabStop = true;
            this.radioScriptSize0.UseVisualStyleBackColor = true;
            this.radioScriptSize0.CheckedChanged += new System.EventHandler(this.radioScriptSize0_CheckedChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(7, 99);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(238, 419);
            this.webBrowser1.TabIndex = 5;
            // 
            // buttonNextDesc
            // 
            this.buttonNextDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNextDesc.Location = new System.Drawing.Point(170, 70);
            this.buttonNextDesc.Name = "buttonNextDesc";
            this.buttonNextDesc.Size = new System.Drawing.Size(75, 23);
            this.buttonNextDesc.TabIndex = 4;
            this.buttonNextDesc.Text = "後";
            this.buttonNextDesc.UseVisualStyleBackColor = true;
            this.buttonNextDesc.Click += new System.EventHandler(this.buttonNextDesc_Click);
            // 
            // buttonPrevDesc
            // 
            this.buttonPrevDesc.Location = new System.Drawing.Point(3, 70);
            this.buttonPrevDesc.Name = "buttonPrevDesc";
            this.buttonPrevDesc.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevDesc.TabIndex = 3;
            this.buttonPrevDesc.Text = "前";
            this.buttonPrevDesc.UseVisualStyleBackColor = true;
            this.buttonPrevDesc.Click += new System.EventHandler(this.buttonPrevDesc_Click);
            // 
            // buttonNextFile
            // 
            this.buttonNextFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNextFile.Location = new System.Drawing.Point(215, 524);
            this.buttonNextFile.Name = "buttonNextFile";
            this.buttonNextFile.Size = new System.Drawing.Size(30, 23);
            this.buttonNextFile.TabIndex = 1;
            this.buttonNextFile.Text = "次";
            this.buttonNextFile.UseVisualStyleBackColor = true;
            this.buttonNextFile.Click += new System.EventHandler(this.buttonNextFile_Click);
            // 
            // buttonPrevFile
            // 
            this.buttonPrevFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPrevFile.Location = new System.Drawing.Point(3, 524);
            this.buttonPrevFile.Name = "buttonPrevFile";
            this.buttonPrevFile.Size = new System.Drawing.Size(30, 23);
            this.buttonPrevFile.TabIndex = 1;
            this.buttonPrevFile.Text = "戻";
            this.buttonPrevFile.UseVisualStyleBackColor = true;
            this.buttonPrevFile.Click += new System.EventHandler(this.buttonPrevFile_Click);
            // 
            // comboBoxFiles
            // 
            this.comboBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiles.FormattingEnabled = true;
            this.comboBoxFiles.Location = new System.Drawing.Point(39, 526);
            this.comboBoxFiles.Name = "comboBoxFiles";
            this.comboBoxFiles.Size = new System.Drawing.Size(170, 20);
            this.comboBoxFiles.TabIndex = 0;
            this.comboBoxFiles.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiles_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 550);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripCompose.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDLineFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDSkips)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox textScript;
		private System.Windows.Forms.Button buttonNextFile;
		private System.Windows.Forms.Button buttonPrevFile;
		private System.Windows.Forms.ComboBox comboBoxFiles;
		private System.Windows.Forms.Button buttonNextDesc;
		private System.Windows.Forms.Button buttonPrevDesc;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.RadioButton radioScriptSize0;
		private System.Windows.Forms.RadioButton radioScriptSize4;
		private System.Windows.Forms.RadioButton radioScriptSize3;
		private System.Windows.Forms.RadioButton radioScriptSize2;
		private System.Windows.Forms.RadioButton radioScriptSize1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonSaveNext;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUDSkips;
		private System.Windows.Forms.RadioButton radioRegexFind;
		private System.Windows.Forms.RadioButton radioNormalFind;
		private System.Windows.Forms.Button buttonCheckSelection;
		private System.Windows.Forms.TextBox textFind;
		private System.Windows.Forms.TextBox textEditDesc;
		private System.Windows.Forms.Button buttonSavePrev;
		private System.Windows.Forms.NumericUpDown numericUDLines;
		private System.Windows.Forms.NumericUpDown numericUDLineFrom;
		private System.Windows.Forms.RadioButton radioLineFind;
		private System.Windows.Forms.Panel panelCompose;
        private System.Windows.Forms.Button buttonFileList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.TextBox textCurrent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCompose;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemSaveMinWidth;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemSaveMaxWidth;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemSaveRatio;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemNew;
    }
}

