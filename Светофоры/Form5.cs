/*
 * Сделано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 06.05.2019
 * Время: 6:56
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Светофоры
{
	/// <summary>
	/// Description of Form5.
	/// </summary>
	public partial class Form5 : Form
	{
		public Form5()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{
            MainForm fr = new MainForm();
            fr.Show();
            Hide();
        }
		
		void Button1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void PictureBox2Click(object sender, EventArgs e)
		{
			pictureBox2.Hide();
		}
		
		void PictureBox3Click(object sender, EventArgs e)
		{
			pictureBox3.Hide();
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			MessageBox.Show("НЕПРАВИЛЬНО!!!","Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
		}
		
		void PictureBox4Click(object sender, EventArgs e)
		{
			MessageBox.Show("НЕПРАВИЛЬНО!!!","Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
		}
	}
}
