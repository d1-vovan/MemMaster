
namespace MemMaster
{
    partial class fMemMaster
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            this.lFontSize = new System.Windows.Forms.Label();
            this.lDivisionIntoSymbols = new System.Windows.Forms.Label();
            this.nudSizeHorizontalSeparator = new System.Windows.Forms.NumericUpDown();
            this.lSizeHorizontalSeparator = new System.Windows.Forms.Label();
            this.nudSizeVerticalSeparator = new System.Windows.Forms.NumericUpDown();
            this.lSizeVerticalSeparator = new System.Windows.Forms.Label();
            this.nudDistanceSeparatorElement = new System.Windows.Forms.NumericUpDown();
            this.lDistanceSeparatorElement = new System.Windows.Forms.Label();
            this.rbVertical = new System.Windows.Forms.RadioButton();
            this.rbHorizontal = new System.Windows.Forms.RadioButton();
            this.bLoadImage = new System.Windows.Forms.Button();
            this.lYourWord = new System.Windows.Forms.Label();
            this.tbYourWord = new System.Windows.Forms.TextBox();
            this.pbSettingsPage = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pbImagePage = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvWords = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOutputImages = new System.Windows.Forms.Button();
            this.bLoadWordsFromDictionary = new System.Windows.Forms.Button();
            this.nudMaxCountOutputWords = new System.Windows.Forms.NumericUpDown();
            this.lMaxCountOutputWords = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeHorizontalSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeVerticalSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistanceSeparatorElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettingsPage)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagePage)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCountOutputWords)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 511);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nudFontSize);
            this.tabPage1.Controls.Add(this.lFontSize);
            this.tabPage1.Controls.Add(this.lDivisionIntoSymbols);
            this.tabPage1.Controls.Add(this.nudSizeHorizontalSeparator);
            this.tabPage1.Controls.Add(this.lSizeHorizontalSeparator);
            this.tabPage1.Controls.Add(this.nudSizeVerticalSeparator);
            this.tabPage1.Controls.Add(this.lSizeVerticalSeparator);
            this.tabPage1.Controls.Add(this.nudDistanceSeparatorElement);
            this.tabPage1.Controls.Add(this.lDistanceSeparatorElement);
            this.tabPage1.Controls.Add(this.rbVertical);
            this.tabPage1.Controls.Add(this.rbHorizontal);
            this.tabPage1.Controls.Add(this.bLoadImage);
            this.tabPage1.Controls.Add(this.lYourWord);
            this.tabPage1.Controls.Add(this.tbYourWord);
            this.tabPage1.Controls.Add(this.pbSettingsPage);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(859, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Настройки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nudFontSize
            // 
            this.nudFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudFontSize.Location = new System.Drawing.Point(11, 443);
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(120, 22);
            this.nudFontSize.TabIndex = 17;
            this.nudFontSize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudFontSize.ValueChanged += new System.EventHandler(this.tbYourWord_TextChanged);
            // 
            // lFontSize
            // 
            this.lFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lFontSize.AutoSize = true;
            this.lFontSize.Location = new System.Drawing.Point(8, 409);
            this.lFontSize.Name = "lFontSize";
            this.lFontSize.Size = new System.Drawing.Size(114, 16);
            this.lFontSize.TabIndex = 16;
            this.lFontSize.Text = "Размер шрифта:";
            // 
            // lDivisionIntoSymbols
            // 
            this.lDivisionIntoSymbols.AutoSize = true;
            this.lDivisionIntoSymbols.Location = new System.Drawing.Point(8, 74);
            this.lDivisionIntoSymbols.Name = "lDivisionIntoSymbols";
            this.lDivisionIntoSymbols.Size = new System.Drawing.Size(146, 16);
            this.lDivisionIntoSymbols.TabIndex = 15;
            this.lDivisionIntoSymbols.Text = "Деление на символы:";
            // 
            // nudSizeHorizontalSeparator
            // 
            this.nudSizeHorizontalSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSizeHorizontalSeparator.Location = new System.Drawing.Point(467, 375);
            this.nudSizeHorizontalSeparator.Name = "nudSizeHorizontalSeparator";
            this.nudSizeHorizontalSeparator.Size = new System.Drawing.Size(120, 22);
            this.nudSizeHorizontalSeparator.TabIndex = 14;
            this.nudSizeHorizontalSeparator.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSizeHorizontalSeparator.ValueChanged += new System.EventHandler(this.tbYourWord_TextChanged);
            // 
            // lSizeHorizontalSeparator
            // 
            this.lSizeHorizontalSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lSizeHorizontalSeparator.AutoSize = true;
            this.lSizeHorizontalSeparator.Location = new System.Drawing.Point(464, 341);
            this.lSizeHorizontalSeparator.Name = "lSizeHorizontalSeparator";
            this.lSizeHorizontalSeparator.Size = new System.Drawing.Size(316, 16);
            this.lSizeHorizontalSeparator.TabIndex = 13;
            this.lSizeHorizontalSeparator.Text = "Ширина горизонтальных разграничителей в px";
            // 
            // nudSizeVerticalSeparator
            // 
            this.nudSizeVerticalSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSizeVerticalSeparator.Location = new System.Drawing.Point(467, 443);
            this.nudSizeVerticalSeparator.Name = "nudSizeVerticalSeparator";
            this.nudSizeVerticalSeparator.Size = new System.Drawing.Size(120, 22);
            this.nudSizeVerticalSeparator.TabIndex = 12;
            this.nudSizeVerticalSeparator.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSizeVerticalSeparator.ValueChanged += new System.EventHandler(this.tbYourWord_TextChanged);
            // 
            // lSizeVerticalSeparator
            // 
            this.lSizeVerticalSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lSizeVerticalSeparator.AutoSize = true;
            this.lSizeVerticalSeparator.Location = new System.Drawing.Point(464, 409);
            this.lSizeVerticalSeparator.Name = "lSizeVerticalSeparator";
            this.lSizeVerticalSeparator.Size = new System.Drawing.Size(304, 16);
            this.lSizeVerticalSeparator.TabIndex = 11;
            this.lSizeVerticalSeparator.Text = "Ширина вертикальных разграничителей в px:";
            // 
            // nudDistanceSeparatorElement
            // 
            this.nudDistanceSeparatorElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudDistanceSeparatorElement.Location = new System.Drawing.Point(11, 375);
            this.nudDistanceSeparatorElement.Name = "nudDistanceSeparatorElement";
            this.nudDistanceSeparatorElement.Size = new System.Drawing.Size(120, 22);
            this.nudDistanceSeparatorElement.TabIndex = 10;
            this.nudDistanceSeparatorElement.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDistanceSeparatorElement.ValueChanged += new System.EventHandler(this.tbYourWord_TextChanged);
            // 
            // lDistanceSeparatorElement
            // 
            this.lDistanceSeparatorElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lDistanceSeparatorElement.AutoSize = true;
            this.lDistanceSeparatorElement.Location = new System.Drawing.Point(8, 341);
            this.lDistanceSeparatorElement.Name = "lDistanceSeparatorElement";
            this.lDistanceSeparatorElement.Size = new System.Drawing.Size(346, 16);
            this.lDistanceSeparatorElement.TabIndex = 9;
            this.lDistanceSeparatorElement.Text = "Расстояние между элементом и разделителем в px:";
            // 
            // rbVertical
            // 
            this.rbVertical.AutoSize = true;
            this.rbVertical.Location = new System.Drawing.Point(11, 139);
            this.rbVertical.Name = "rbVertical";
            this.rbVertical.Size = new System.Drawing.Size(119, 20);
            this.rbVertical.TabIndex = 8;
            this.rbVertical.Text = "По вертикали";
            this.rbVertical.UseVisualStyleBackColor = true;
            // 
            // rbHorizontal
            // 
            this.rbHorizontal.AutoSize = true;
            this.rbHorizontal.Checked = true;
            this.rbHorizontal.Location = new System.Drawing.Point(11, 103);
            this.rbHorizontal.Name = "rbHorizontal";
            this.rbHorizontal.Size = new System.Drawing.Size(134, 20);
            this.rbHorizontal.TabIndex = 7;
            this.rbHorizontal.TabStop = true;
            this.rbHorizontal.Text = "По горизонтали";
            this.rbHorizontal.UseVisualStyleBackColor = true;
            // 
            // bLoadImage
            // 
            this.bLoadImage.Location = new System.Drawing.Point(8, 6);
            this.bLoadImage.Name = "bLoadImage";
            this.bLoadImage.Size = new System.Drawing.Size(185, 35);
            this.bLoadImage.TabIndex = 6;
            this.bLoadImage.Text = "Загрузка изображения";
            this.bLoadImage.UseVisualStyleBackColor = true;
            this.bLoadImage.Click += new System.EventHandler(this.bLoadImage_Click);
            // 
            // lYourWord
            // 
            this.lYourWord.AutoSize = true;
            this.lYourWord.Location = new System.Drawing.Point(5, 195);
            this.lYourWord.Name = "lYourWord";
            this.lYourWord.Size = new System.Drawing.Size(86, 16);
            this.lYourWord.TabIndex = 5;
            this.lYourWord.Text = "Ваше слово:";
            // 
            // tbYourWord
            // 
            this.tbYourWord.Location = new System.Drawing.Point(8, 224);
            this.tbYourWord.MaxLength = 20;
            this.tbYourWord.Name = "tbYourWord";
            this.tbYourWord.Size = new System.Drawing.Size(141, 22);
            this.tbYourWord.TabIndex = 4;
            this.tbYourWord.Text = "Test";
            this.tbYourWord.TextChanged += new System.EventHandler(this.tbYourWord_TextChanged);
            // 
            // pbSettingsPage
            // 
            this.pbSettingsPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSettingsPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSettingsPage.Location = new System.Drawing.Point(208, 6);
            this.pbSettingsPage.Name = "pbSettingsPage";
            this.pbSettingsPage.Size = new System.Drawing.Size(633, 316);
            this.pbSettingsPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSettingsPage.TabIndex = 3;
            this.pbSettingsPage.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pbImagePage);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(859, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Изображение";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pbImagePage
            // 
            this.pbImagePage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagePage.Location = new System.Drawing.Point(8, 6);
            this.pbImagePage.Name = "pbImagePage";
            this.pbImagePage.Size = new System.Drawing.Size(831, 454);
            this.pbImagePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagePage.TabIndex = 0;
            this.pbImagePage.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvWords);
            this.tabPage3.Controls.Add(this.bOutputImages);
            this.tabPage3.Controls.Add(this.bLoadWordsFromDictionary);
            this.tabPage3.Controls.Add(this.nudMaxCountOutputWords);
            this.tabPage3.Controls.Add(this.lMaxCountOutputWords);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(859, 482);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Варианты слов";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvWords
            // 
            this.dgvWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvWords.Location = new System.Drawing.Point(328, 58);
            this.dgvWords.Name = "dgvWords";
            this.dgvWords.RowHeadersWidth = 51;
            this.dgvWords.RowTemplate.Height = 24;
            this.dgvWords.Size = new System.Drawing.Size(441, 335);
            this.dgvWords.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Слово";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Приоритет";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // bOutputImages
            // 
            this.bOutputImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bOutputImages.Location = new System.Drawing.Point(46, 334);
            this.bOutputImages.Name = "bOutputImages";
            this.bOutputImages.Size = new System.Drawing.Size(240, 59);
            this.bOutputImages.TabIndex = 4;
            this.bOutputImages.Text = "Вывод полученных изображений в формате png";
            this.bOutputImages.UseVisualStyleBackColor = true;
            this.bOutputImages.Click += new System.EventHandler(this.bOutputImages_Click);
            // 
            // bLoadWordsFromDictionary
            // 
            this.bLoadWordsFromDictionary.Location = new System.Drawing.Point(46, 58);
            this.bLoadWordsFromDictionary.Name = "bLoadWordsFromDictionary";
            this.bLoadWordsFromDictionary.Size = new System.Drawing.Size(240, 59);
            this.bLoadWordsFromDictionary.TabIndex = 3;
            this.bLoadWordsFromDictionary.Text = "Загрузка из txt";
            this.bLoadWordsFromDictionary.UseVisualStyleBackColor = true;
            this.bLoadWordsFromDictionary.Click += new System.EventHandler(this.bLoadWordsFromDictionary_Click);
            // 
            // nudMaxCountOutputWords
            // 
            this.nudMaxCountOutputWords.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudMaxCountOutputWords.Location = new System.Drawing.Point(46, 232);
            this.nudMaxCountOutputWords.Name = "nudMaxCountOutputWords";
            this.nudMaxCountOutputWords.Size = new System.Drawing.Size(120, 22);
            this.nudMaxCountOutputWords.TabIndex = 2;
            this.nudMaxCountOutputWords.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lMaxCountOutputWords
            // 
            this.lMaxCountOutputWords.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lMaxCountOutputWords.AutoSize = true;
            this.lMaxCountOutputWords.Location = new System.Drawing.Point(43, 198);
            this.lMaxCountOutputWords.Name = "lMaxCountOutputWords";
            this.lMaxCountOutputWords.Size = new System.Drawing.Size(218, 16);
            this.lMaxCountOutputWords.TabIndex = 1;
            this.lMaxCountOutputWords.Text = "Максимальное количество слов";
            // 
            // fMemMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 501);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(875, 548);
            this.Name = "fMemMaster";
            this.Text = "MemMaster";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeHorizontalSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeVerticalSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistanceSeparatorElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettingsPage)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagePage)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCountOutputWords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pbImagePage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown nudMaxCountOutputWords;
        private System.Windows.Forms.Label lMaxCountOutputWords;
        private System.Windows.Forms.Button bLoadWordsFromDictionary;
        private System.Windows.Forms.Button bOutputImages;
        private System.Windows.Forms.DataGridView dgvWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.NumericUpDown nudFontSize;
        private System.Windows.Forms.Label lFontSize;
        private System.Windows.Forms.Label lDivisionIntoSymbols;
        private System.Windows.Forms.NumericUpDown nudSizeHorizontalSeparator;
        private System.Windows.Forms.Label lSizeHorizontalSeparator;
        private System.Windows.Forms.NumericUpDown nudSizeVerticalSeparator;
        private System.Windows.Forms.Label lSizeVerticalSeparator;
        private System.Windows.Forms.NumericUpDown nudDistanceSeparatorElement;
        private System.Windows.Forms.Label lDistanceSeparatorElement;
        private System.Windows.Forms.RadioButton rbVertical;
        private System.Windows.Forms.RadioButton rbHorizontal;
        private System.Windows.Forms.Button bLoadImage;
        private System.Windows.Forms.Label lYourWord;
        private System.Windows.Forms.TextBox tbYourWord;
        private System.Windows.Forms.PictureBox pbSettingsPage;
    }
}

