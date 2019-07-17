/*
 * Сделано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 05.05.2019
 * Время: 3:31
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Светофоры
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
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
		
		void PictureBox20Click(object sender, EventArgs e)
		{
			MessageBox.Show("НЕПРАВИЛЬНО!!!","Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
		}
		
		void PictureBox40Click(object sender, EventArgs e)
		{
			pictureBox41.BackColor = Color.YellowGreen;
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			pictureBox1.BackColor = Color.YellowGreen;
		}
		
		void PictureBox4Click(object sender, EventArgs e)
		{
			pictureBox12.BackColor = Color.YellowGreen;
		}
		
		void PictureBox34Click(object sender, EventArgs e)
		{
			pictureBox35.BackColor = Color.YellowGreen;
		}
		
		void PictureBox23Click(object sender, EventArgs e)
		{
			pictureBox21.BackColor = Color.YellowGreen;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			if((pictureBox41.BackColor == Color.YellowGreen) && (pictureBox1.BackColor == Color.YellowGreen) && (pictureBox12.BackColor == Color.YellowGreen) && (pictureBox35.BackColor == Color.YellowGreen) && (pictureBox21.BackColor == Color.YellowGreen))
			{
				Form2 fr2 = new Form2();
				fr2.Show();
				Hide();
			}
				
			
		}
	}
}
