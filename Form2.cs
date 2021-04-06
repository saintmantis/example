using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Anisimov_Egor
{
	public partial class Form2 : Form
	{
		Peredacha peredacha = new Peredacha();
		public Form2(Peredacha p)
		{
			// тут всё что в оглаавлении таблицы
			InitializeComponent();
			dataGridView1.RowCount = p.i+1;
			dataGridView1.ColumnCount = 32; 
			dataGridView1.Rows[0].Cells[0].Value = "Передача";
			dataGridView1.Rows[0].Cells[1].Value = "Способ расчёта D1";
			dataGridView1.Rows[0].Cells[2].Value = "Мощность"; // мощность
			dataGridView1.Rows[0].Cells[3].Value = "n1 частота вращения"; // частота вращения
			dataGridView1.Rows[0].Cells[4].Value = "вид ремня"; // вид ремня
			dataGridView1.Rows[0].Cells[5].Value = "D1v"; // без комментариев
			dataGridView1.Rows[0].Cells[6].Value = "Вид ткани"; // вид ткани
			dataGridView1.Rows[0].Cells[7].Value = "Число прокладок"; // число прокладок
			dataGridView1.Rows[0].Cells[8].Value = "Ширина ремня"; // ширина ремня
			dataGridView1.Rows[0].Cells[9].Value = "наличие прослоек"; // 
			dataGridView1.Rows[0].Cells[10].Value = "толщина синт"; // 
			dataGridView1.Rows[0].Cells[11].Value = "n2 частота вращения"; // 
			dataGridView1.Rows[0].Cells[12].Value = "Е, частота вращения"; // 
			dataGridView1.Rows[0].Cells[13].Value = "Вид передачи"; // 
			dataGridView1.Rows[0].Cells[14].Value = "Способ L"; // способ определения длины ремня
			dataGridView1.Rows[0].Cells[15].Value = "Ir"; // частота пробега ремня в секундах 
			dataGridView1.Rows[0].Cells[16].Value = "VidMatRem"; // материал и вид фрикционного покрытия
			dataGridView1.Rows[0].Cells[17].Value = "ширина b CKH-40"; // определение ширины ремня CKH-40
			dataGridView1.Rows[0].Cells[18].Value = "ширина b"; // определение ширины ремня для капроновой ткани
			dataGridView1.Rows[0].Cells[19].Value = "D1"; // 
			dataGridView1.Rows[0].Cells[20].Value = "a) D1"; // по саверина
			dataGridView1.Rows[0].Cells[21].Value = "b) D1";
			dataGridView1.Rows[0].Cells[22].Value = "v) D1";
			dataGridView1.Rows[0].Cells[23].Value = "g) D1";
			dataGridView1.Rows[0].Cells[24].Value = "V";
			dataGridView1.Rows[0].Cells[25].Value = "u";
			dataGridView1.Rows[0].Cells[26].Value = "D2";
			dataGridView1.Rows[0].Cells[27].Value = "a(min)";
			dataGridView1.Rows[0].Cells[28].Value = "K";
			dataGridView1.Rows[0].Cells[29].Value = "L";
			dataGridView1.Rows[0].Cells[30].Value = "a";
			dataGridView1.Rows[0].Cells[31].Value = "a1";


			for (int r = 1; r <= p.i; r++)
			{
				dataGridView1.Rows[r].Cells[0].Value = r;
				dataGridView1.Rows[r].Cells[1].Value = p.abvg[r].ToString();
				dataGridView1.Rows[r].Cells[2].Value = p.N[r].ToString();
				dataGridView1.Rows[r].Cells[3].Value = p.n1[r].ToString();
				dataGridView1.Rows[r].Cells[4].Value = p.VidRem[r].ToString();
				dataGridView1.Rows[r].Cells[5].Value = p.D1v[r].ToString();
				dataGridView1.Rows[r].Cells[6].Value = p.VidTKA[r].ToString();
				dataGridView1.Rows[r].Cells[7].Value = p.prok[r].ToString();
				dataGridView1.Rows[r].Cells[8].Value = p.b[r].ToString();
				dataGridView1.Rows[r].Cells[9].Value = p.prosnal[r].ToString();
				dataGridView1.Rows[r].Cells[10].Value = p.Del[r].ToString();
				dataGridView1.Rows[r].Cells[11].Value = p.n2[r].ToString();
				dataGridView1.Rows[r].Cells[12].Value = p.E[r].ToString();
				dataGridView1.Rows[r].Cells[13].Value = p.VidPer[r].ToString();
				dataGridView1.Rows[r].Cells[14].Value = p.SposobL[r].ToString();
				dataGridView1.Rows[r].Cells[15].Value = p.nchastots[r].ToString();
				dataGridView1.Rows[r].Cells[16].Value = p.MatVid[r].ToString();
				dataGridView1.Rows[r].Cells[17].Value = p.OprShirremCKH_40[r].ToString();
				dataGridView1.Rows[r].Cells[18].Value = p.OprShirremSar[r].ToString();
				dataGridView1.Rows[r].Cells[19].Value = p.D1[r].ToString();
				dataGridView1.Rows[r].Cells[20].Value = p.D1a[r].ToString();
				dataGridView1.Rows[r].Cells[21].Value = p.D1b[r].ToString();
				dataGridView1.Rows[r].Cells[22].Value = p.D1v[r].ToString();
				dataGridView1.Rows[r].Cells[23].Value = p.D1g[r].ToString();
				dataGridView1.Rows[r].Cells[24].Value = p.v[r].ToString();
				dataGridView1.Rows[r].Cells[25].Value = p.u[r].ToString();
				dataGridView1.Rows[r].Cells[26].Value = p.D2[r].ToString();
				dataGridView1.Rows[r].Cells[27].Value = p.amin[r].ToString();
				dataGridView1.Rows[r].Cells[28].Value = p.K[r].ToString();
				dataGridView1.Rows[r].Cells[29].Value = p.L[r].ToString();
				dataGridView1.Rows[r].Cells[30].Value = p.a[r].ToString();
				dataGridView1.Rows[r].Cells[31].Value = p.a1[r].ToString();


				dataGridView1.RowCount++;

			}
			peredacha = p;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

			#region 
			//сортировка по возрастанию
			/*
			Peredacha p = peredacha;
			

			int[] Номер_передачи = new int[15];
			double[] a = new double[15];

			for (int r = 1; r <= p.i; r++)
			{
				Номер_передачи[r] = p.Nomer[r];
				a[r] = p.a[r];

			}
			for(int r = 1; r<=p.i; r++)
			{
				//
				for (int l = 1; l <= p.i; l++)
				{
					if (a[l] >= a[l + 1])
					{
						double q = a[l]; int iq = Номер_передачи[l];
						a[l] = a[l + 1]; Номер_передачи[l] = Номер_передачи[l + 1];
						a[l + 1] = q; Номер_передачи[l + 1] = iq;
					}
				}
				//
			}
			for (int r = 1; r <= p.i; r++)
			{
				for (int l = 1; l <= p.i; l++)
				{
					if (Номер_передачи[r] == p.Nomer[l])
					{

						dataGridView1.Rows[r].Cells[0].Value = p.Nomer[l].ToString();
						dataGridView1.Rows[r].Cells[1].Value = p.abvg[l].ToString();
						dataGridView1.Rows[r].Cells[2].Value = p.N[l].ToString();
						dataGridView1.Rows[r].Cells[3].Value = p.n1[l].ToString();
						dataGridView1.Rows[r].Cells[4].Value = p.VidRem[l].ToString();
						dataGridView1.Rows[r].Cells[5].Value = p.D1v[l].ToString();
						dataGridView1.Rows[r].Cells[6].Value = p.VidTKA[l].ToString();
						dataGridView1.Rows[r].Cells[7].Value = p.prok[l].ToString();
						dataGridView1.Rows[r].Cells[8].Value = p.b[l].ToString();
						dataGridView1.Rows[r].Cells[9].Value = p.prosnal[l].ToString();
						dataGridView1.Rows[r].Cells[10].Value = p.Del[l].ToString();
						dataGridView1.Rows[r].Cells[11].Value = p.n2[l].ToString();
						dataGridView1.Rows[r].Cells[12].Value = p.E[l].ToString();
						dataGridView1.Rows[r].Cells[13].Value = p.VidPer[l].ToString();
						dataGridView1.Rows[r].Cells[14].Value = p.SposobL[l].ToString();
						dataGridView1.Rows[r].Cells[15].Value = p.nchastots[l].ToString();
						dataGridView1.Rows[r].Cells[16].Value = p.MatVid[l].ToString();
						dataGridView1.Rows[r].Cells[17].Value = p.OprShirremCKH_40[l].ToString();
						dataGridView1.Rows[r].Cells[18].Value = p.OprShirremSar[l].ToString();
						dataGridView1.Rows[r].Cells[19].Value = p.D1[l].ToString();
						dataGridView1.Rows[r].Cells[20].Value = p.D1a[l].ToString();
						dataGridView1.Rows[r].Cells[21].Value = p.D1b[l].ToString();
						dataGridView1.Rows[r].Cells[22].Value = p.D1v[l].ToString();
						dataGridView1.Rows[r].Cells[23].Value = p.D1g[l].ToString();
						dataGridView1.Rows[r].Cells[24].Value = p.v[l].ToString();
						dataGridView1.Rows[r].Cells[25].Value = p.u[l].ToString();
						dataGridView1.Rows[r].Cells[26].Value = p.D2[l].ToString();
						dataGridView1.Rows[r].Cells[27].Value = p.amin[l].ToString();
						dataGridView1.Rows[r].Cells[28].Value = p.K[l].ToString();
						dataGridView1.Rows[r].Cells[29].Value = p.L[l].ToString();
						dataGridView1.Rows[r].Cells[30].Value = p.a[l].ToString();
						dataGridView1.Rows[r].Cells[31].Value = p.a1[l].ToString();


						//dataGridView1.RowCount++;

					}
				}
			} 
			*/
			#endregion

			#region
			
			double[] a = new double[15];
			int[] Номер_передачи = new int[15];
			Peredacha p = peredacha;

			for (int r = 1; r <= p.i; r++)
			{
				Номер_передачи[r] = p.Nomer[r];
				a[r] = p.a[r];

			}

			//
			
			double[,] matrix = new double[2, 15];
			double[,] temp = new double[2, 1];

			for (int i = 1; i <= p.i; i++)
			{
				matrix[0, i] = a[i];
				matrix[1, i] = i + 1;
			}

			

			for (int i = 0; i <= p.i; i++)
			{
				for (int j = i + 1; j <= p.i; j++)
				{
					if (matrix[0, i] >= matrix[0, j])
					{
						temp[0, 0] = matrix[0, i];
						temp[1, 0] = matrix[1, i];

						matrix[0, i] = matrix[0, j];
						matrix[1, i] = matrix[1, j];

						matrix[0, j] = temp[0, 0];
						matrix[1, j] = temp[1, 0];
					}
				}
			}
			//

			for (int i = 0; i <= p.i; i++)
			{
				matrix[1, i] = matrix[1, i]-1;
			}


				int index = 1;
			//int target = 1;
			for (int i = 1; i <= p.i; i++)
			{
				index = Convert.ToInt32(matrix[1, i]);
				
			
					dataGridView1.Rows[i].Cells[0].Value = p.Nomer[index].ToString();
					dataGridView1.Rows[i].Cells[1].Value = p.abvg[index].ToString();
					dataGridView1.Rows[i].Cells[2].Value = p.N[index].ToString();
					dataGridView1.Rows[i].Cells[3].Value = p.n1[index].ToString();
					dataGridView1.Rows[i].Cells[4].Value = p.VidRem[index].ToString();
					dataGridView1.Rows[i].Cells[5].Value = p.D1v[index].ToString();
					dataGridView1.Rows[i].Cells[6].Value = p.VidTKA[index].ToString();
					dataGridView1.Rows[i].Cells[7].Value = p.prok[index].ToString();
					dataGridView1.Rows[i].Cells[8].Value = p.b[index].ToString();
					dataGridView1.Rows[i].Cells[9].Value = p.prosnal[index].ToString();
					dataGridView1.Rows[i].Cells[10].Value = p.Del[index].ToString();
					dataGridView1.Rows[i].Cells[11].Value = p.n2[index].ToString();
					dataGridView1.Rows[i].Cells[12].Value = p.E[index].ToString();
					dataGridView1.Rows[i].Cells[13].Value = p.VidPer[index].ToString();
					dataGridView1.Rows[i].Cells[14].Value = p.SposobL[index].ToString();
					dataGridView1.Rows[i].Cells[15].Value = p.nchastots[index].ToString();
					dataGridView1.Rows[i].Cells[16].Value = p.MatVid[index].ToString();
					dataGridView1.Rows[i].Cells[17].Value = p.OprShirremCKH_40[index].ToString();
					dataGridView1.Rows[i].Cells[18].Value = p.OprShirremSar[index].ToString();
					dataGridView1.Rows[i].Cells[19].Value = p.D1[index].ToString();
					dataGridView1.Rows[i].Cells[20].Value = p.D1a[index].ToString();
					dataGridView1.Rows[i].Cells[21].Value = p.D1b[index].ToString();
					dataGridView1.Rows[i].Cells[22].Value = p.D1v[index].ToString();
					dataGridView1.Rows[i].Cells[23].Value = p.D1g[index].ToString();
					dataGridView1.Rows[i].Cells[24].Value = p.v[index].ToString();
					dataGridView1.Rows[i].Cells[25].Value = p.u[index].ToString();
					dataGridView1.Rows[i].Cells[26].Value = p.D2[index].ToString();
					dataGridView1.Rows[i].Cells[27].Value = p.amin[index].ToString();
					dataGridView1.Rows[i].Cells[28].Value = p.K[index].ToString();
					dataGridView1.Rows[i].Cells[29].Value = p.L[index].ToString();
					dataGridView1.Rows[i].Cells[30].Value = p.a[index].ToString();
					dataGridView1.Rows[i].Cells[31].Value = p.a1[index].ToString();
					//i = 0;
					//target++;
				

				if (index == 0)
					break;


			}
			/*
			double index = 1;
			int target = 1;
			for (int i = 1; i <= p.i; i++)
			{

				index = matrix[1, i]; // индекс который нужно поставить на первое место
				if (index == target)
				{
					dataGridView1.Rows[i].Cells[0].Value = p.Nomer[i].ToString();
					dataGridView1.Rows[i].Cells[1].Value = p.abvg[i].ToString();
					dataGridView1.Rows[i].Cells[2].Value = p.N[i].ToString();
					dataGridView1.Rows[i].Cells[3].Value = p.n1[i].ToString();
					dataGridView1.Rows[i].Cells[4].Value = p.VidRem[i].ToString();
					dataGridView1.Rows[i].Cells[5].Value = p.D1v[i].ToString();
					dataGridView1.Rows[i].Cells[6].Value = p.VidTKA[i].ToString();
					dataGridView1.Rows[i].Cells[7].Value = p.prok[i].ToString();
					dataGridView1.Rows[i].Cells[8].Value = p.b[i].ToString();
					dataGridView1.Rows[i].Cells[9].Value = p.prosnal[i].ToString();
					dataGridView1.Rows[i].Cells[10].Value = p.Del[i].ToString();
					dataGridView1.Rows[i].Cells[11].Value = p.n2[i].ToString();
					dataGridView1.Rows[i].Cells[12].Value = p.E[i].ToString();
					dataGridView1.Rows[i].Cells[13].Value = p.VidPer[i].ToString();
					dataGridView1.Rows[i].Cells[14].Value = p.SposobL[i].ToString();
					dataGridView1.Rows[i].Cells[15].Value = p.nchastots[i].ToString();
					dataGridView1.Rows[i].Cells[16].Value = p.MatVid[i].ToString();
					dataGridView1.Rows[i].Cells[17].Value = p.OprShirremCKH_40[i].ToString();
					dataGridView1.Rows[i].Cells[18].Value = p.OprShirremSar[i].ToString();
					dataGridView1.Rows[i].Cells[19].Value = p.D1[i].ToString();
					dataGridView1.Rows[i].Cells[20].Value = p.D1a[i].ToString();
					dataGridView1.Rows[i].Cells[21].Value = p.D1b[i].ToString();
					dataGridView1.Rows[i].Cells[22].Value = p.D1v[i].ToString();
					dataGridView1.Rows[i].Cells[23].Value = p.D1g[i].ToString();
					dataGridView1.Rows[i].Cells[24].Value = p.v[i].ToString();
					dataGridView1.Rows[i].Cells[25].Value = p.u[i].ToString();
					dataGridView1.Rows[i].Cells[26].Value = p.D2[i].ToString();
					dataGridView1.Rows[i].Cells[27].Value = p.amin[i].ToString();
					dataGridView1.Rows[i].Cells[28].Value = p.K[i].ToString();
					dataGridView1.Rows[i].Cells[29].Value = p.L[i].ToString();
					dataGridView1.Rows[i].Cells[30].Value = p.a[i].ToString();
					dataGridView1.Rows[i].Cells[31].Value = p.a1[i].ToString();
					i = 0;
					target++;
				}

				if (index == 0)
					break;


			}
			//
			*/
			/*
			for (int r = 1; r <= p.i; r++)
			{
				dataGridView1.Rows[r].Cells[0].Value = r;
				dataGridView1.Rows[r].Cells[1].Value = p.abvg[r].ToString();
				dataGridView1.Rows[r].Cells[2].Value = p.N[r].ToString();
				dataGridView1.Rows[r].Cells[3].Value = p.n1[r].ToString();
				dataGridView1.Rows[r].Cells[4].Value = p.VidRem[r].ToString();
				dataGridView1.Rows[r].Cells[5].Value = p.D1v[r].ToString();
				dataGridView1.Rows[r].Cells[6].Value = p.VidTKA[r].ToString();
				dataGridView1.Rows[r].Cells[7].Value = p.prok[r].ToString();
				dataGridView1.Rows[r].Cells[8].Value = p.b[r].ToString();
				dataGridView1.Rows[r].Cells[9].Value = p.prosnal[r].ToString();
				dataGridView1.Rows[r].Cells[10].Value = p.Del[r].ToString();
				dataGridView1.Rows[r].Cells[11].Value = p.n2[r].ToString();
				dataGridView1.Rows[r].Cells[12].Value = p.E[r].ToString();
				dataGridView1.Rows[r].Cells[13].Value = p.VidPer[r].ToString();
				dataGridView1.Rows[r].Cells[14].Value = p.SposobL[r].ToString();
				dataGridView1.Rows[r].Cells[15].Value = p.nchastots[r].ToString();
				dataGridView1.Rows[r].Cells[16].Value = p.MatVid[r].ToString();
				dataGridView1.Rows[r].Cells[17].Value = p.OprShirremCKH_40[r].ToString();
				dataGridView1.Rows[r].Cells[18].Value = p.OprShirremSar[r].ToString();
				dataGridView1.Rows[r].Cells[19].Value = p.D1[r].ToString();
				dataGridView1.Rows[r].Cells[20].Value = p.D1a[r].ToString();
				dataGridView1.Rows[r].Cells[21].Value = p.D1b[r].ToString();
				dataGridView1.Rows[r].Cells[22].Value = p.D1v[r].ToString();
				dataGridView1.Rows[r].Cells[23].Value = p.D1g[r].ToString();
				dataGridView1.Rows[r].Cells[24].Value = p.v[r].ToString();
				dataGridView1.Rows[r].Cells[25].Value = p.u[r].ToString();
				dataGridView1.Rows[r].Cells[26].Value = p.D2[r].ToString();
				dataGridView1.Rows[r].Cells[27].Value = p.amin[r].ToString();
				dataGridView1.Rows[r].Cells[28].Value = p.K[r].ToString();
				dataGridView1.Rows[r].Cells[29].Value = p.L[r].ToString();
				dataGridView1.Rows[r].Cells[30].Value = p.a[r].ToString();
				dataGridView1.Rows[r].Cells[31].Value = p.a1[r].ToString();


				dataGridView1.RowCount++;

			}
			*/
			#endregion
		}

		private void button2_Click(object sender, EventArgs e) // поиск
		{
			double poisk = Convert.ToDouble(textBox1.Text);
			Peredacha p = peredacha;
			int i = 1;
			dataGridView1.Rows.Clear();
			dataGridView1.Columns.Clear();
			dataGridView1.RowCount = p.i + 1;
			dataGridView1.ColumnCount = 32;
			//
			dataGridView1.Rows[0].Cells[0].Value = "Передача";
			dataGridView1.Rows[0].Cells[1].Value = "Способ расчёта D1";
			dataGridView1.Rows[0].Cells[2].Value = "Мощность"; // мощность
			dataGridView1.Rows[0].Cells[3].Value = "n1 частота вращения"; // частота вращения
			dataGridView1.Rows[0].Cells[4].Value = "вид ремня"; // вид ремня
			dataGridView1.Rows[0].Cells[5].Value = "D1v"; // без комментариев
			dataGridView1.Rows[0].Cells[6].Value = "Вид ткани"; // вид ткани
			dataGridView1.Rows[0].Cells[7].Value = "Число прокладок"; // число прокладок
			dataGridView1.Rows[0].Cells[8].Value = "Ширина ремня"; // ширина ремня
			dataGridView1.Rows[0].Cells[9].Value = "наличие прослоек"; // 
			dataGridView1.Rows[0].Cells[10].Value = "толщина синт"; // 
			dataGridView1.Rows[0].Cells[11].Value = "n2 частота вращения"; // 
			dataGridView1.Rows[0].Cells[12].Value = "Е, частота вращения"; // 
			dataGridView1.Rows[0].Cells[13].Value = "Вид передачи"; // 
			dataGridView1.Rows[0].Cells[14].Value = "Способ L"; // способ определения длины ремня
			dataGridView1.Rows[0].Cells[15].Value = "Ir"; // частота пробега ремня в секундах 
			dataGridView1.Rows[0].Cells[16].Value = "VidMatRem"; // материал и вид фрикционного покрытия
			dataGridView1.Rows[0].Cells[17].Value = "ширина b CKH-40"; // определение ширины ремня CKH-40
			dataGridView1.Rows[0].Cells[18].Value = "ширина b"; // определение ширины ремня для капроновой ткани
			dataGridView1.Rows[0].Cells[19].Value = "D1"; // 
			dataGridView1.Rows[0].Cells[20].Value = "a) D1"; // по саверина
			dataGridView1.Rows[0].Cells[21].Value = "b) D1";
			dataGridView1.Rows[0].Cells[22].Value = "v) D1";
			dataGridView1.Rows[0].Cells[23].Value = "g) D1";
			dataGridView1.Rows[0].Cells[24].Value = "V";
			dataGridView1.Rows[0].Cells[25].Value = "u";
			dataGridView1.Rows[0].Cells[26].Value = "D2";
			dataGridView1.Rows[0].Cells[27].Value = "a(min)";
			dataGridView1.Rows[0].Cells[28].Value = "K";
			dataGridView1.Rows[0].Cells[29].Value = "L";
			dataGridView1.Rows[0].Cells[30].Value = "a";
			dataGridView1.Rows[0].Cells[31].Value = "a1";
			//
			for (int r = 1; r<=p.i; r++)
			{
				if (poisk == p.D1[r])
				{

					dataGridView1.Rows[i].Cells[0].Value = p.Nomer[r].ToString();
					dataGridView1.Rows[i].Cells[1].Value = p.abvg[r].ToString();
					dataGridView1.Rows[i].Cells[2].Value = p.N[r].ToString();
					dataGridView1.Rows[i].Cells[3].Value = p.n1[r].ToString();
					dataGridView1.Rows[i].Cells[4].Value = p.VidRem[r].ToString();
					dataGridView1.Rows[i].Cells[5].Value = p.D1v[r].ToString();
					dataGridView1.Rows[i].Cells[6].Value = p.VidTKA[r].ToString();
					dataGridView1.Rows[i].Cells[7].Value = p.prok[r].ToString();
					dataGridView1.Rows[i].Cells[8].Value = p.b[r].ToString();
					dataGridView1.Rows[i].Cells[9].Value = p.prosnal[r].ToString();
					dataGridView1.Rows[i].Cells[10].Value = p.Del[r].ToString();
					dataGridView1.Rows[i].Cells[11].Value = p.n2[r].ToString();
					dataGridView1.Rows[i].Cells[12].Value = p.E[r].ToString();
					dataGridView1.Rows[i].Cells[13].Value = p.VidPer[r].ToString();
					dataGridView1.Rows[i].Cells[14].Value = p.SposobL[r].ToString();
					dataGridView1.Rows[i].Cells[15].Value = p.nchastots[r].ToString();
					dataGridView1.Rows[i].Cells[16].Value = p.MatVid[r].ToString();
					dataGridView1.Rows[i].Cells[17].Value = p.OprShirremCKH_40[r].ToString();
					dataGridView1.Rows[i].Cells[18].Value = p.OprShirremSar[r].ToString();
					dataGridView1.Rows[i].Cells[19].Value = p.D1[r].ToString();
					dataGridView1.Rows[i].Cells[20].Value = p.D1a[r].ToString();
					dataGridView1.Rows[i].Cells[21].Value = p.D1b[r].ToString();
					dataGridView1.Rows[i].Cells[22].Value = p.D1v[r].ToString();
					dataGridView1.Rows[i].Cells[23].Value = p.D1g[r].ToString();
					dataGridView1.Rows[i].Cells[24].Value = p.v[r].ToString();
					dataGridView1.Rows[i].Cells[25].Value = p.u[r].ToString();
					dataGridView1.Rows[i].Cells[26].Value = p.D2[r].ToString();
					dataGridView1.Rows[i].Cells[27].Value = p.amin[r].ToString();
					dataGridView1.Rows[i].Cells[28].Value = p.K[r].ToString();
					dataGridView1.Rows[i].Cells[29].Value = p.L[r].ToString();
					dataGridView1.Rows[i].Cells[30].Value = p.a[r].ToString();
					dataGridView1.Rows[i].Cells[31].Value = p.a1[r].ToString();
					i++;
				}
			}
		}

		private void button3_Click(object sender, EventArgs e) // сортировка по L
		{
			double[] a = new double[15];
			int[] Номер_передачи = new int[15];
			Peredacha p = peredacha;

			for (int r = 1; r <= p.i; r++)
			{
				Номер_передачи[r] = p.Nomer[r];
				a[r] = p.L[r];

			}

			//

			double[,] matrix = new double[2, 15];
			double[,] temp = new double[2, 1];

			for (int i = 1; i <= p.i; i++)
			{
				matrix[0, i] = a[i];
				matrix[1, i] = i + 1;
			}



			for (int i = 0; i <= p.i; i++)
			{
				for (int j = i + 1; j <= p.i; j++)
				{
					if (matrix[0, i] >= matrix[0, j])
					{
						temp[0, 0] = matrix[0, i];
						temp[1, 0] = matrix[1, i];

						matrix[0, i] = matrix[0, j];
						matrix[1, i] = matrix[1, j];

						matrix[0, j] = temp[0, 0];
						matrix[1, j] = temp[1, 0];
					}
				}
			}
			//

			for (int i = 0; i <= p.i; i++)
			{
				matrix[1, i] = matrix[1, i] - 1;
			}


			int index = 1;
			//int target = 1;
			for (int i = 1; i <= p.i; i++)
			{
				index = Convert.ToInt32(matrix[1, i]);


				dataGridView1.Rows[i].Cells[0].Value = p.Nomer[index].ToString();
				dataGridView1.Rows[i].Cells[1].Value = p.abvg[index].ToString();
				dataGridView1.Rows[i].Cells[2].Value = p.N[index].ToString();
				dataGridView1.Rows[i].Cells[3].Value = p.n1[index].ToString();
				dataGridView1.Rows[i].Cells[4].Value = p.VidRem[index].ToString();
				dataGridView1.Rows[i].Cells[5].Value = p.D1v[index].ToString();
				dataGridView1.Rows[i].Cells[6].Value = p.VidTKA[index].ToString();
				dataGridView1.Rows[i].Cells[7].Value = p.prok[index].ToString();
				dataGridView1.Rows[i].Cells[8].Value = p.b[index].ToString();
				dataGridView1.Rows[i].Cells[9].Value = p.prosnal[index].ToString();
				dataGridView1.Rows[i].Cells[10].Value = p.Del[index].ToString();
				dataGridView1.Rows[i].Cells[11].Value = p.n2[index].ToString();
				dataGridView1.Rows[i].Cells[12].Value = p.E[index].ToString();
				dataGridView1.Rows[i].Cells[13].Value = p.VidPer[index].ToString();
				dataGridView1.Rows[i].Cells[14].Value = p.SposobL[index].ToString();
				dataGridView1.Rows[i].Cells[15].Value = p.nchastots[index].ToString();
				dataGridView1.Rows[i].Cells[16].Value = p.MatVid[index].ToString();
				dataGridView1.Rows[i].Cells[17].Value = p.OprShirremCKH_40[index].ToString();
				dataGridView1.Rows[i].Cells[18].Value = p.OprShirremSar[index].ToString();
				dataGridView1.Rows[i].Cells[19].Value = p.D1[index].ToString();
				dataGridView1.Rows[i].Cells[20].Value = p.D1a[index].ToString();
				dataGridView1.Rows[i].Cells[21].Value = p.D1b[index].ToString();
				dataGridView1.Rows[i].Cells[22].Value = p.D1v[index].ToString();
				dataGridView1.Rows[i].Cells[23].Value = p.D1g[index].ToString();
				dataGridView1.Rows[i].Cells[24].Value = p.v[index].ToString();
				dataGridView1.Rows[i].Cells[25].Value = p.u[index].ToString();
				dataGridView1.Rows[i].Cells[26].Value = p.D2[index].ToString();
				dataGridView1.Rows[i].Cells[27].Value = p.amin[index].ToString();
				dataGridView1.Rows[i].Cells[28].Value = p.K[index].ToString();
				dataGridView1.Rows[i].Cells[29].Value = p.L[index].ToString();
				dataGridView1.Rows[i].Cells[30].Value = p.a[index].ToString();
				dataGridView1.Rows[i].Cells[31].Value = p.a1[index].ToString();
				//i = 0;
				//target++;


				if (index == 0)
					break;


			}
		}

		private void button4_Click(object sender, EventArgs e) // сортировка по а1
		{
			double[] a = new double[15];
			int[] Номер_передачи = new int[15];
			Peredacha p = peredacha;

			for (int r = 1; r <= p.i; r++)
			{
				Номер_передачи[r] = p.Nomer[r];
				a[r] = p.a1[r];

			}
			//

			double[,] matrix = new double[2, 15];
			double[,] temp = new double[2, 1];

			for (int i = 1; i <= p.i; i++)
			{
				matrix[0, i] = a[i];
				matrix[1, i] = i + 1;
			}



			for (int i = 0; i <= p.i; i++)
			{
				for (int j = i + 1; j <= p.i; j++)
				{
					if (matrix[0, i] >= matrix[0, j])
					{
						temp[0, 0] = matrix[0, i];
						temp[1, 0] = matrix[1, i];

						matrix[0, i] = matrix[0, j];
						matrix[1, i] = matrix[1, j];

						matrix[0, j] = temp[0, 0];
						matrix[1, j] = temp[1, 0];
					}
				}
			}
			//

			for (int i = 0; i <= p.i; i++)
			{
				matrix[1, i] = matrix[1, i] - 1;
			}


			int index = 1;
			//int target = 1;
			for (int i = 1; i <= p.i; i++)
			{
				index = Convert.ToInt32(matrix[1, i]);


				dataGridView1.Rows[i].Cells[0].Value = p.Nomer[index].ToString();
				dataGridView1.Rows[i].Cells[1].Value = p.abvg[index].ToString();
				dataGridView1.Rows[i].Cells[2].Value = p.N[index].ToString();
				dataGridView1.Rows[i].Cells[3].Value = p.n1[index].ToString();
				dataGridView1.Rows[i].Cells[4].Value = p.VidRem[index].ToString();
				dataGridView1.Rows[i].Cells[5].Value = p.D1v[index].ToString();
				dataGridView1.Rows[i].Cells[6].Value = p.VidTKA[index].ToString();
				dataGridView1.Rows[i].Cells[7].Value = p.prok[index].ToString();
				dataGridView1.Rows[i].Cells[8].Value = p.b[index].ToString();
				dataGridView1.Rows[i].Cells[9].Value = p.prosnal[index].ToString();
				dataGridView1.Rows[i].Cells[10].Value = p.Del[index].ToString();
				dataGridView1.Rows[i].Cells[11].Value = p.n2[index].ToString();
				dataGridView1.Rows[i].Cells[12].Value = p.E[index].ToString();
				dataGridView1.Rows[i].Cells[13].Value = p.VidPer[index].ToString();
				dataGridView1.Rows[i].Cells[14].Value = p.SposobL[index].ToString();
				dataGridView1.Rows[i].Cells[15].Value = p.nchastots[index].ToString();
				dataGridView1.Rows[i].Cells[16].Value = p.MatVid[index].ToString();
				dataGridView1.Rows[i].Cells[17].Value = p.OprShirremCKH_40[index].ToString();
				dataGridView1.Rows[i].Cells[18].Value = p.OprShirremSar[index].ToString();
				dataGridView1.Rows[i].Cells[19].Value = p.D1[index].ToString();
				dataGridView1.Rows[i].Cells[20].Value = p.D1a[index].ToString();
				dataGridView1.Rows[i].Cells[21].Value = p.D1b[index].ToString();
				dataGridView1.Rows[i].Cells[22].Value = p.D1v[index].ToString();
				dataGridView1.Rows[i].Cells[23].Value = p.D1g[index].ToString();
				dataGridView1.Rows[i].Cells[24].Value = p.v[index].ToString();
				dataGridView1.Rows[i].Cells[25].Value = p.u[index].ToString();
				dataGridView1.Rows[i].Cells[26].Value = p.D2[index].ToString();
				dataGridView1.Rows[i].Cells[27].Value = p.amin[index].ToString();
				dataGridView1.Rows[i].Cells[28].Value = p.K[index].ToString();
				dataGridView1.Rows[i].Cells[29].Value = p.L[index].ToString();
				dataGridView1.Rows[i].Cells[30].Value = p.a[index].ToString();
				dataGridView1.Rows[i].Cells[31].Value = p.a1[index].ToString();
				//i = 0;
				//target++;


				if (index == 0)
					break;


			}
		}

		private void button5_Click(object sender, EventArgs e) // сортировка а (мин)
		{
			double[] a = new double[15];
			int[] Номер_передачи = new int[15];
			Peredacha p = peredacha;

			for (int r = 1; r <= p.i; r++)
			{
				Номер_передачи[r] = p.Nomer[r];
				a[r] = p.amin[r];

			}
			//

			double[,] matrix = new double[2, 15];
			double[,] temp = new double[2, 1];

			for (int i = 1; i <= p.i; i++)
			{
				matrix[0, i] = a[i];
				matrix[1, i] = i + 1;
			}



			for (int i = 0; i <= p.i; i++)
			{
				for (int j = i + 1; j <= p.i; j++)
				{
					if (matrix[0, i] >= matrix[0, j])
					{
						temp[0, 0] = matrix[0, i];
						temp[1, 0] = matrix[1, i];

						matrix[0, i] = matrix[0, j];
						matrix[1, i] = matrix[1, j];

						matrix[0, j] = temp[0, 0];
						matrix[1, j] = temp[1, 0];
					}
				}
			}
			//

			for (int i = 0; i <= p.i; i++)
			{
				matrix[1, i] = matrix[1, i] - 1;
			}


			int index = 1;
			//int target = 1;
			for (int i = 1; i <= p.i; i++)
			{
				index = Convert.ToInt32(matrix[1, i]);


				dataGridView1.Rows[i].Cells[0].Value = p.Nomer[index].ToString();
				dataGridView1.Rows[i].Cells[1].Value = p.abvg[index].ToString();
				dataGridView1.Rows[i].Cells[2].Value = p.N[index].ToString();
				dataGridView1.Rows[i].Cells[3].Value = p.n1[index].ToString();
				dataGridView1.Rows[i].Cells[4].Value = p.VidRem[index].ToString();
				dataGridView1.Rows[i].Cells[5].Value = p.D1v[index].ToString();
				dataGridView1.Rows[i].Cells[6].Value = p.VidTKA[index].ToString();
				dataGridView1.Rows[i].Cells[7].Value = p.prok[index].ToString();
				dataGridView1.Rows[i].Cells[8].Value = p.b[index].ToString();
				dataGridView1.Rows[i].Cells[9].Value = p.prosnal[index].ToString();
				dataGridView1.Rows[i].Cells[10].Value = p.Del[index].ToString();
				dataGridView1.Rows[i].Cells[11].Value = p.n2[index].ToString();
				dataGridView1.Rows[i].Cells[12].Value = p.E[index].ToString();
				dataGridView1.Rows[i].Cells[13].Value = p.VidPer[index].ToString();
				dataGridView1.Rows[i].Cells[14].Value = p.SposobL[index].ToString();
				dataGridView1.Rows[i].Cells[15].Value = p.nchastots[index].ToString();
				dataGridView1.Rows[i].Cells[16].Value = p.MatVid[index].ToString();
				dataGridView1.Rows[i].Cells[17].Value = p.OprShirremCKH_40[index].ToString();
				dataGridView1.Rows[i].Cells[18].Value = p.OprShirremSar[index].ToString();
				dataGridView1.Rows[i].Cells[19].Value = p.D1[index].ToString();
				dataGridView1.Rows[i].Cells[20].Value = p.D1a[index].ToString();
				dataGridView1.Rows[i].Cells[21].Value = p.D1b[index].ToString();
				dataGridView1.Rows[i].Cells[22].Value = p.D1v[index].ToString();
				dataGridView1.Rows[i].Cells[23].Value = p.D1g[index].ToString();
				dataGridView1.Rows[i].Cells[24].Value = p.v[index].ToString();
				dataGridView1.Rows[i].Cells[25].Value = p.u[index].ToString();
				dataGridView1.Rows[i].Cells[26].Value = p.D2[index].ToString();
				dataGridView1.Rows[i].Cells[27].Value = p.amin[index].ToString();
				dataGridView1.Rows[i].Cells[28].Value = p.K[index].ToString();
				dataGridView1.Rows[i].Cells[29].Value = p.L[index].ToString();
				dataGridView1.Rows[i].Cells[30].Value = p.a[index].ToString();
				dataGridView1.Rows[i].Cells[31].Value = p.a1[index].ToString();
				//i = 0;
				//target++;


				if (index == 0)
					break;


			}
		}

		private void button6_Click(object sender, EventArgs e) // сортировка v
		{
			double[] a = new double[15];
			int[] Номер_передачи = new int[15];
			Peredacha p = peredacha;

			for (int r = 1; r <= p.i; r++)
			{
				Номер_передачи[r] = p.Nomer[r];
				a[r] = p.amin[r];

			}
			//

			double[,] matrix = new double[2, 15];
			double[,] temp = new double[2, 1];

			for (int i = 1; i <= p.i; i++)
			{
				matrix[0, i] = a[i];
				matrix[1, i] = i + 1;
			}



			for (int i = 0; i <= p.i; i++)
			{
				for (int j = i + 1; j <= p.i; j++)
				{
					if (matrix[0, i] >= matrix[0, j])
					{
						temp[0, 0] = matrix[0, i];
						temp[1, 0] = matrix[1, i];

						matrix[0, i] = matrix[0, j];
						matrix[1, i] = matrix[1, j];

						matrix[0, j] = temp[0, 0];
						matrix[1, j] = temp[1, 0];
					}
				}
			}
			//

			for (int i = 0; i <= p.i; i++)
			{
				matrix[1, i] = matrix[1, i] - 1;
			}


			int index = 1;
			//int target = 1;
			for (int i = 1; i <= p.i; i++)
			{
				index = Convert.ToInt32(matrix[1, i]);


				dataGridView1.Rows[i].Cells[0].Value = p.Nomer[index].ToString();
				dataGridView1.Rows[i].Cells[1].Value = p.abvg[index].ToString();
				dataGridView1.Rows[i].Cells[2].Value = p.N[index].ToString();
				dataGridView1.Rows[i].Cells[3].Value = p.n1[index].ToString();
				dataGridView1.Rows[i].Cells[4].Value = p.VidRem[index].ToString();
				dataGridView1.Rows[i].Cells[5].Value = p.D1v[index].ToString();
				dataGridView1.Rows[i].Cells[6].Value = p.VidTKA[index].ToString();
				dataGridView1.Rows[i].Cells[7].Value = p.prok[index].ToString();
				dataGridView1.Rows[i].Cells[8].Value = p.b[index].ToString();
				dataGridView1.Rows[i].Cells[9].Value = p.prosnal[index].ToString();
				dataGridView1.Rows[i].Cells[10].Value = p.Del[index].ToString();
				dataGridView1.Rows[i].Cells[11].Value = p.n2[index].ToString();
				dataGridView1.Rows[i].Cells[12].Value = p.E[index].ToString();
				dataGridView1.Rows[i].Cells[13].Value = p.VidPer[index].ToString();
				dataGridView1.Rows[i].Cells[14].Value = p.SposobL[index].ToString();
				dataGridView1.Rows[i].Cells[15].Value = p.nchastots[index].ToString();
				dataGridView1.Rows[i].Cells[16].Value = p.MatVid[index].ToString();
				dataGridView1.Rows[i].Cells[17].Value = p.OprShirremCKH_40[index].ToString();
				dataGridView1.Rows[i].Cells[18].Value = p.OprShirremSar[index].ToString();
				dataGridView1.Rows[i].Cells[19].Value = p.D1[index].ToString();
				dataGridView1.Rows[i].Cells[20].Value = p.D1a[index].ToString();
				dataGridView1.Rows[i].Cells[21].Value = p.D1b[index].ToString();
				dataGridView1.Rows[i].Cells[22].Value = p.D1v[index].ToString();
				dataGridView1.Rows[i].Cells[23].Value = p.D1g[index].ToString();
				dataGridView1.Rows[i].Cells[24].Value = p.v[index].ToString();
				dataGridView1.Rows[i].Cells[25].Value = p.u[index].ToString();
				dataGridView1.Rows[i].Cells[26].Value = p.D2[index].ToString();
				dataGridView1.Rows[i].Cells[27].Value = p.amin[index].ToString();
				dataGridView1.Rows[i].Cells[28].Value = p.K[index].ToString();
				dataGridView1.Rows[i].Cells[29].Value = p.L[index].ToString();
				dataGridView1.Rows[i].Cells[30].Value = p.a[index].ToString();
				dataGridView1.Rows[i].Cells[31].Value = p.a1[index].ToString();
				//i = 0;
				//target++;


				if (index == 0)
					break;


			}
		}

		private void button7_Click(object sender, EventArgs e) // сортировка D1
		{
			double[] a = new double[15];
			int[] Номер_передачи = new int[15];
			Peredacha p = peredacha;

			for (int r = 1; r <= p.i; r++)
			{
				Номер_передачи[r] = p.Nomer[r];
				a[r] = p.D1[r];

			}
			//

			double[,] matrix = new double[2, 15];
			double[,] temp = new double[2, 1];

			for (int i = 1; i <= p.i; i++)
			{
				matrix[0, i] = a[i];
				matrix[1, i] = i + 1;
			}



			for (int i = 0; i <= p.i; i++)
			{
				for (int j = i + 1; j <= p.i; j++)
				{
					if (matrix[0, i] >= matrix[0, j])
					{
						temp[0, 0] = matrix[0, i];
						temp[1, 0] = matrix[1, i];

						matrix[0, i] = matrix[0, j];
						matrix[1, i] = matrix[1, j];

						matrix[0, j] = temp[0, 0];
						matrix[1, j] = temp[1, 0];
					}
				}
			}
			//

			for (int i = 0; i <= p.i; i++)
			{
				matrix[1, i] = matrix[1, i] - 1;
			}


			int index = 1;
			//int target = 1;
			for (int i = 1; i <= p.i; i++)
			{
				index = Convert.ToInt32(matrix[1, i]);


				dataGridView1.Rows[i].Cells[0].Value = p.Nomer[index].ToString();
				dataGridView1.Rows[i].Cells[1].Value = p.abvg[index].ToString();
				dataGridView1.Rows[i].Cells[2].Value = p.N[index].ToString();
				dataGridView1.Rows[i].Cells[3].Value = p.n1[index].ToString();
				dataGridView1.Rows[i].Cells[4].Value = p.VidRem[index].ToString();
				dataGridView1.Rows[i].Cells[5].Value = p.D1v[index].ToString();
				dataGridView1.Rows[i].Cells[6].Value = p.VidTKA[index].ToString();
				dataGridView1.Rows[i].Cells[7].Value = p.prok[index].ToString();
				dataGridView1.Rows[i].Cells[8].Value = p.b[index].ToString();
				dataGridView1.Rows[i].Cells[9].Value = p.prosnal[index].ToString();
				dataGridView1.Rows[i].Cells[10].Value = p.Del[index].ToString();
				dataGridView1.Rows[i].Cells[11].Value = p.n2[index].ToString();
				dataGridView1.Rows[i].Cells[12].Value = p.E[index].ToString();
				dataGridView1.Rows[i].Cells[13].Value = p.VidPer[index].ToString();
				dataGridView1.Rows[i].Cells[14].Value = p.SposobL[index].ToString();
				dataGridView1.Rows[i].Cells[15].Value = p.nchastots[index].ToString();
				dataGridView1.Rows[i].Cells[16].Value = p.MatVid[index].ToString();
				dataGridView1.Rows[i].Cells[17].Value = p.OprShirremCKH_40[index].ToString();
				dataGridView1.Rows[i].Cells[18].Value = p.OprShirremSar[index].ToString();
				dataGridView1.Rows[i].Cells[19].Value = p.D1[index].ToString();
				dataGridView1.Rows[i].Cells[20].Value = p.D1a[index].ToString();
				dataGridView1.Rows[i].Cells[21].Value = p.D1b[index].ToString();
				dataGridView1.Rows[i].Cells[22].Value = p.D1v[index].ToString();
				dataGridView1.Rows[i].Cells[23].Value = p.D1g[index].ToString();
				dataGridView1.Rows[i].Cells[24].Value = p.v[index].ToString();
				dataGridView1.Rows[i].Cells[25].Value = p.u[index].ToString();
				dataGridView1.Rows[i].Cells[26].Value = p.D2[index].ToString();
				dataGridView1.Rows[i].Cells[27].Value = p.amin[index].ToString();
				dataGridView1.Rows[i].Cells[28].Value = p.K[index].ToString();
				dataGridView1.Rows[i].Cells[29].Value = p.L[index].ToString();
				dataGridView1.Rows[i].Cells[30].Value = p.a[index].ToString();
				dataGridView1.Rows[i].Cells[31].Value = p.a1[index].ToString();
				//i = 0;
				//target++;


				if (index == 0)
					break;


			}
		}
	}
}
