/*
 * Сделано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 05.05.2019
 * Время: 7:05
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Светофоры
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		public Form3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			MainForm fr = new MainForm();
			fr.Show();
			Hide();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			if((pictureBox12.BackColor == Color.YellowGreen) && (pictureBox8.BackColor == Color.YellowGreen) && (pictureBox9.BackColor == Color.YellowGreen))
			{
				Form2 fr2 = new Form2();
				fr2.Show();
				Hide();
			}
		}
		
		void PictureBox5Click(object sender, EventArgs e)
		{
			MessageBox.Show("НЕПРАВИЛЬНО!!!","Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
		pictureBox12.BackColor = Color.YellowGreen;
		}
		
		void PictureBox6Click(object sender, EventArgs e)
		{
			pictureBox8.BackColor = Color.YellowGreen;
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			pictureBox9.BackColor = Color.YellowGreen;
		}
	}
}