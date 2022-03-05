using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemMaster
{
    public partial class fMemMaster : Form
    {
        public Bitmap image = new Bitmap(1, 1);
        public fMemMaster()
        {
            InitializeComponent();
            pbSettingsPage.Image = Properties.Resources.startImage;
            image = Properties.Resources.startImage;
            tbYourWord_TextChanged(new object(), new System.EventArgs());
        }

        Bitmap GetBitmapRegion(Rectangle rect)
        {
            Bitmap region = new Bitmap(rect.Width, rect.Height);
            using (Graphics g = Graphics.FromImage(region))
            {
                g.DrawImage(image, new Rectangle(0, 0, rect.Width, rect.Height), rect, GraphicsUnit.Pixel);
            }

            return region;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        public int GetIndexBitmaps(char ch, string textbox)
        {
            for (int i = 0; i < textbox.Length; i++)
                if (ch == textbox[i])
                    return i;
            return 0;
        }

        public Bitmap GetOutImage(string wp)
        {
            List<Bitmap> bitmaps = new List<Bitmap>();
            for (int i = 0; i < tbYourWord.Text.Length; i++)
                if (rbHorizontal.Checked)
                {
                    int width = image.Width / tbYourWord.Text.Length;
                    int x = width * i;
                    bitmaps.Add(GetBitmapRegion(new Rectangle(x, 0, width, image.Height)));
                }
                else
                {
                    int height = image.Height / tbYourWord.Text.Length;
                    int y = height * i;
                    bitmaps.Add(GetBitmapRegion(new Rectangle(0, y, image.Width, height)));
                }
            Bitmap new_image = new Bitmap(1, 1);


            if (rbHorizontal.Checked)
            {
                int Xsteps_null = (wp.Length - 1) * (int)nudDistanceSeparatorElement.Value * 2;
                int Xsteps_otdel = (wp.Length - 1) * (int)nudSizeVerticalSeparator.Value;//Ширина всех отделителей
                int Ysteps_otdel = 50 + (int)nudSizeHorizontalSeparator.Value + 50 + 50;//Дополнительные пиксели снизу для разделительной полосы + место для буквы
                new_image = new Bitmap(wp.Length * (image.Width / tbYourWord.Text.Length) + Xsteps_null + Xsteps_otdel, image.Height + Ysteps_otdel);
                Graphics grph = Graphics.FromImage(new_image);

                // Вставляем в новое изображения куски старого
                for (int i = 0; i < wp.Length; i++)
                {
                    int Xsteps_im = i * (image.Width / tbYourWord.Text.Length);
                    int Xsteps_nu = i * (int)nudDistanceSeparatorElement.Value * 2;
                    int Xstart = Xsteps_im + Xsteps_nu;
                    int ind_bitmaps = GetIndexBitmaps(wp[i], tbYourWord.Text);
                    grph.DrawImage(bitmaps[ind_bitmaps], Xstart, 0);

                    // Рисуем вертикальный разграничитель
                    if (i != bitmaps.Count - 1)
                    {
                        Point v_p1 = new Point(Xstart + bitmaps[ind_bitmaps].Width + (int)nudDistanceSeparatorElement.Value, 0);
                        Point v_p2 = new Point(Xstart + bitmaps[ind_bitmaps].Width + (int)nudDistanceSeparatorElement.Value, bitmaps[ind_bitmaps].Height);
                        grph.DrawLine(new Pen(Color.Black, (float)nudSizeVerticalSeparator.Value), v_p1, v_p2);
                    }

                    // Рисуем символ
                    RectangleF rect = new RectangleF(Xstart, image.Height + 50 + (float)nudSizeHorizontalSeparator.Value + 50, bitmaps[ind_bitmaps].Width, 50);
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    grph.DrawString(wp[i].ToString(), new Font("Segoe UI", (float)nudFontSize.Value, FontStyle.Bold), new SolidBrush(Color.Black), rect, sf);
                }

                // Рисуем горизонтальный отделитель
                Point g_p1 = new Point(0, image.Height + 50);
                Point g_p2 = new Point(new_image.Width - (int)nudDistanceSeparatorElement.Value - (int)nudSizeVerticalSeparator.Value, image.Height + 50);
                grph.DrawLine(new Pen(Color.Black, (float)nudSizeHorizontalSeparator.Value), g_p1, g_p2);
            }

            return new_image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void tbYourWord_TextChanged(object sender, EventArgs e)
        {
            if (tbYourWord.Text.Length == 0)
                tbYourWord.Text = "Test";

            List<Bitmap> bitmaps = new List<Bitmap>();
            for (int i = 0; i < tbYourWord.Text.Length; i++)
                if (rbHorizontal.Checked)
                {
                    int width = image.Width / tbYourWord.Text.Length;
                    int x = width * i;
                    bitmaps.Add(GetBitmapRegion(new Rectangle(x, 0, width, image.Height)));
                }
                else
                {
                    int height = image.Height / tbYourWord.Text.Length;
                    int y = height * i;
                    bitmaps.Add(GetBitmapRegion(new Rectangle(0, y, image.Width, height)));
                }

            if (rbHorizontal.Checked)
            {
                int Xsteps_null = (tbYourWord.Text.Length - 1) * (int)nudDistanceSeparatorElement.Value * 2;
                int Xsteps_otdel = (tbYourWord.Text.Length - 1) * (int)nudSizeVerticalSeparator.Value;//Ширина всех отделителей
                int Ysteps_otdel = 50 + (int)nudSizeHorizontalSeparator.Value + 50 + 50;//Дополнительные пиксели снизу для разделительной полосы + место для буквы
                Bitmap new_image = new Bitmap(image.Width + Xsteps_null + Xsteps_otdel, image.Height + Ysteps_otdel);
                Graphics grph = Graphics.FromImage(new_image);

                // Вставляем в новое изображения куски старого
                for (int i = 0; i < bitmaps.Count; i++)
                {
                    int Xsteps_im = i * (image.Width / tbYourWord.Text.Length);
                    int Xsteps_nu = i * (int)nudDistanceSeparatorElement.Value * 2;
                    int Xstart = Xsteps_im + Xsteps_nu;
                    grph.DrawImage(bitmaps[i], Xstart, 0);

                    // Рисуем вертикальный разграничитель
                    if (i != bitmaps.Count - 1)
                    {
                        Point v_p1 = new Point(Xstart + bitmaps[i].Width + (int)nudDistanceSeparatorElement.Value, 0);
                        Point v_p2 = new Point(Xstart + bitmaps[i].Width + (int)nudDistanceSeparatorElement.Value, bitmaps[i].Height);
                        grph.DrawLine(new Pen(Color.Black, (float)nudSizeVerticalSeparator.Value), v_p1, v_p2);
                    }

                    // Рисуем символ
                    RectangleF rect = new RectangleF(Xstart, image.Height + 50 + (float)nudSizeHorizontalSeparator.Value + 50, bitmaps[i].Width, 50);
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    grph.DrawString(tbYourWord.Text[i].ToString(), new Font("Segoe UI", (float)nudFontSize.Value, FontStyle.Bold), new SolidBrush(Color.Black), rect, sf);
                }

                // Рисуем горизонтальный отделитель
                Point g_p1 = new Point(0, image.Height + 50);
                Point g_p2 = new Point(new_image.Width - (int)nudDistanceSeparatorElement.Value - (int)nudSizeVerticalSeparator.Value, image.Height + 50);
                grph.DrawLine(new Pen(Color.Black, (float)nudSizeHorizontalSeparator.Value), g_p1, g_p2);

                // Вставляем новое изображение
                pbSettingsPage.Image = new_image;
                pbImagePage.Image = new_image;
            }
        }

        private void bLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    pbSettingsPage.Image = image;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            tbYourWord_TextChanged(sender, e);
        }

        private void bLoadWordsFromDictionary_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(open_dialog.FileName);
                    string line;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        dgvWords.Rows.Add(line.Split('/')[0], line.Split('/')[1]);
                    }
                    sr.Close();
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bOutputImages_Click(object sender, EventArgs e)
        {
            List<WordPrioryti> wps = new List<WordPrioryti>();
            for (int i = 0; i < dgvWords.Rows.Count - 1; i++)
                wps.Add(new WordPrioryti(dgvWords.Rows[i]));

            wps.Sort(delegate (WordPrioryti x, WordPrioryti y) {
                return y.prioryti.CompareTo(x.prioryti);
            });
            // Определяем те слова, которые можно составить из заданного пользователем
            for (int i = wps.Count - 1; i > -1; i--)
                if (!wps[i].ContainAllSymbols(tbYourWord.Text.ToLower()))
                    wps.RemoveAt(i);
            if (wps.Count == 0)
            {
                MessageBox.Show("Не найдено ни одного подходящего слова. Попробуйте добавить слов", "Нет результата");
                return;
            }
            // Оставляем только n необходимых элементов
            for (int i = (int)nudMaxCountOutputWords.Value - 1; i < wps.Count; i++)
                wps.RemoveAt(i);


            for (int i = 0; i < wps.Count; i++)
            {
                Bitmap im = GetOutImage(wps[i].word);
                string name = wps[i].word + "__";
                int j = 1;
                while (File.Exists(name + ".png"))
                {
                    if (j > 1)
                        name = name.Substring(name.Length - 3);
                    name += "(" + j + ")";
                    j++;
                }
                im.Save(name + ".png", System.Drawing.Imaging.ImageFormat.Png);
            }
            MessageBox.Show("Картинки успешно сгенерированы. Найти их можно в папке проекта", "Успех");
        }
    }
}