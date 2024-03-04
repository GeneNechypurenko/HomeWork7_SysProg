namespace HomeWork7
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            searchButton = new Button();
            stopButton = new Button();
            subdirectoryCheckBox = new CheckBox();
            fileTextBox = new TextBox();
            keyWordSearchTextBox = new TextBox();
            directoryComboBox = new ComboBox();
            resultLabel = new Label();
            outputListView = new ListView();
            nameHeader = new ColumnHeader();
            pathHeader = new ColumnHeader();
            sizeHeader = new ColumnHeader();
            createdAtHeader = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "Файл";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 9);
            label2.Name = "label2";
            label2.Size = new Size(210, 20);
            label2.TabIndex = 1;
            label2.Text = "Поиск по ключевому слову";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 9);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Диски";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(577, 30);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(118, 29);
            searchButton.TabIndex = 3;
            searchButton.Text = "НАЙТИ";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(701, 30);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(118, 29);
            stopButton.TabIndex = 4;
            stopButton.Text = "ОСТАНОВИТЬ";
            stopButton.UseVisualStyleBackColor = true;
            // 
            // subdirectoryCheckBox
            // 
            subdirectoryCheckBox.AutoSize = true;
            subdirectoryCheckBox.Location = new Point(825, 30);
            subdirectoryCheckBox.Name = "subdirectoryCheckBox";
            subdirectoryCheckBox.Size = new Size(124, 24);
            subdirectoryCheckBox.TabIndex = 5;
            subdirectoryCheckBox.Text = "Подкаталоги";
            subdirectoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // fileTextBox
            // 
            fileTextBox.Location = new Point(12, 32);
            fileTextBox.Name = "fileTextBox";
            fileTextBox.Size = new Size(125, 27);
            fileTextBox.TabIndex = 6;
            // 
            // keyWordSearchTextBox
            // 
            keyWordSearchTextBox.Location = new Point(143, 31);
            keyWordSearchTextBox.Name = "keyWordSearchTextBox";
            keyWordSearchTextBox.Size = new Size(269, 27);
            keyWordSearchTextBox.TabIndex = 7;
            // 
            // directoryComboBox
            // 
            directoryComboBox.FormattingEnabled = true;
            directoryComboBox.Location = new Point(418, 30);
            directoryComboBox.Name = "directoryComboBox";
            directoryComboBox.Size = new Size(153, 28);
            directoryComboBox.TabIndex = 8;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(333, 77);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(153, 20);
            resultLabel.TabIndex = 10;
            resultLabel.Text = "результаты поиска: ";
            // 
            // outputListView
            // 
            outputListView.Columns.AddRange(new ColumnHeader[] { nameHeader, pathHeader, sizeHeader, createdAtHeader });
            outputListView.Location = new Point(12, 110);
            outputListView.Name = "outputListView";
            outputListView.Size = new Size(932, 503);
            outputListView.TabIndex = 11;
            outputListView.UseCompatibleStateImageBehavior = false;
            outputListView.View = View.Details;
            // 
            // nameHeader
            // 
            nameHeader.Text = "Имя";
            nameHeader.Width = 200;
            // 
            // pathHeader
            // 
            pathHeader.Text = "Папка";
            pathHeader.Width = 400;
            // 
            // sizeHeader
            // 
            sizeHeader.Text = "Размер";
            sizeHeader.Width = 150;
            // 
            // createdAtHeader
            // 
            createdAtHeader.Text = "Дата Модификации";
            createdAtHeader.Width = 200;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 625);
            Controls.Add(outputListView);
            Controls.Add(resultLabel);
            Controls.Add(directoryComboBox);
            Controls.Add(keyWordSearchTextBox);
            Controls.Add(fileTextBox);
            Controls.Add(subdirectoryCheckBox);
            Controls.Add(stopButton);
            Controls.Add(searchButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Поиск файлов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button searchButton;
        private Button stopButton;
        private CheckBox subdirectoryCheckBox;
        private TextBox fileTextBox;
        private TextBox keyWordSearchTextBox;
        private ComboBox directoryComboBox;
        private Label resultLabel;
        private ListView outputListView;
        private ColumnHeader nameHeader;
        private ColumnHeader pathHeader;
        private ColumnHeader sizeHeader;
        private ColumnHeader createdAtHeader;
    }
}
