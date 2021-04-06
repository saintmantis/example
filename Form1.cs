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
	
	public partial class Form1 : Form
	{
		Peredacha peredacha = new Peredacha();
		// List<Peredacha> allp = new List<Peredacha>(100);
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

			

			peredacha.i++;
			peredacha.Nomer[peredacha.i]++;//добавил для сортировки


			if ((comboBox1.Text=="") || (textBox19.Text == "") || (textBoxx2.Text == "") || (textBox1.Text == ""))
			{
				Form5 newForm = new Form5();
				newForm.Show();
			}

			peredacha.Nomer[peredacha.i] = peredacha.i; // номер ппередач
			peredacha.abvg[peredacha.i] = comboBox1.Text; // данные о комбобоксе
			peredacha.VidRem[peredacha.i] = "нет";
			peredacha.VidTKA[peredacha.i] = "нет";
			peredacha.prosnal[peredacha.i] = "нет";
			peredacha.VidPer[peredacha.i] = "нет";
			peredacha.SposobL[peredacha.i] = "нет";
			peredacha.MatVid[peredacha.i] = "нет";
			peredacha.OprShirremSar[peredacha.i] = "нет";
			peredacha.OprShirremCKH_40[peredacha.i] = "нет";


			// тут все функции
			double D1 = CalculationD1(); // вернет D1 текущую
			DeterminationOfTheCoefficient(); // поиск коэффициента и скорости 
			CalculationD2(); //  Определение диаметра большего шкива, D2 и передаточночного числа
			CalculationAmin(); // Расчёт межосевого расстояния, a(min)
			CalculationL(); // Определение длины ремня в зависимости от заданных условий, L
			CalculationA(); // Определение межосевого расстояния, а 
			CalculationA1(); // Определение угла обхвата на меньшем шкиве
			// конец всех функций

			// таблица 
			tbl();
			//
			//allp.Add(peredacha);
			
			
		}

		// обработчик события нажатия на кнопку

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
			if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
			{

				textBox18.Text = Convert.ToString(peredacha.a1[e.ColumnIndex]); // присваиваем значение ураааа получилось
				textBox17.Text = Convert.ToString(peredacha.a[e.ColumnIndex]);
				textBox16.Text = Convert.ToString(peredacha.L[e.ColumnIndex]);
				textBox15.Text = Convert.ToString(peredacha.K[e.ColumnIndex]);
				textBox14.Text = Convert.ToString(peredacha.amin[e.ColumnIndex]);
				textBox13.Text = Convert.ToString(peredacha.D2[e.ColumnIndex]);
				textBox12.Text = Convert.ToString(peredacha.u[e.ColumnIndex]);
				textBox11.Text = Convert.ToString(peredacha.v[e.ColumnIndex]);
				textBox10.Text = Convert.ToString(peredacha.D1g[e.ColumnIndex]);
				textBox9.Text = Convert.ToString(peredacha.D1v[e.ColumnIndex]);
				textBox8.Text = Convert.ToString(peredacha.D1b[e.ColumnIndex]);
				textBox7.Text = Convert.ToString(peredacha.D1a[e.ColumnIndex]);

			}
			
			//срабатывает событие
		}



			public void CalculationA1()
		{
			peredacha.a1[peredacha.i] = 180 - ((peredacha.D2[peredacha.i] - peredacha.D1[peredacha.i]) / peredacha.a[peredacha.i]) * 57;
			textBox18.Text = Convert.ToString(peredacha.a1[peredacha.i]);
		}
		public void CalculationA()
		{
			double del = peredacha.L[peredacha.i] - Math.PI * ((peredacha.D1[peredacha.i] + peredacha.D2[peredacha.i]) / 2);
			double triangle = (peredacha.D2[peredacha.i] - peredacha.D1[peredacha.i]) / 2;
			peredacha.a[peredacha.i] = (del + Math.Sqrt((del * del) - 8 * (triangle * triangle))) / 4;
			textBox17.Text = Convert.ToString(peredacha.a[peredacha.i]);
			
		}
		public void CalculationL()
		{
			peredacha.SposobL[peredacha.i] = comboBox8.Text;

			peredacha.nchastots[peredacha.i] = Convert.ToDouble(textBox6.Text);
			if (peredacha.SposobL[peredacha.i] == "a) По выбранному межосевому расстоянию")
			{
				
				peredacha.MatVid[peredacha.i] = comboBox9.Text;
				peredacha.OprShirremCKH_40[peredacha.i] = comboBox10.Text;
				peredacha.OprShirremSar[peredacha.i] = comboBox11.Text;
				peredacha.L[peredacha.i] = 2 * peredacha.amin[peredacha.i] + Math.PI * (peredacha.D1[peredacha.i] + peredacha.D2[peredacha.i]) / 2 + ((peredacha.D2[peredacha.i] - peredacha.D1[peredacha.i]) * (peredacha.D2[peredacha.i] - peredacha.D1[peredacha.i])) / (4 * peredacha.amin[peredacha.i]);
				
				double Lmin = peredacha.v[peredacha.i] / peredacha.nchastots[peredacha.i];
				if (peredacha.L[peredacha.i] >= Lmin)
				{
					// все ок не меняем значение L
				}
				
				else
				{
					if ((30 < peredacha.v[peredacha.i]) && (peredacha.v[peredacha.i] < 50)) // округление по таблице 3
					{
						if (peredacha.MatVid[peredacha.i] == "Капроновая ткань просвечивающего или полотянного переплятения, покрытая пленкой из полимиада в соединении с нитральным каучаком CKH - 40")
						{
							if (peredacha.OprShirremCKH_40[peredacha.i] == "10")
							{
								peredacha.L[peredacha.i] = 250;
							}
							if (peredacha.OprShirremCKH_40[peredacha.i] == "15")
							{
								peredacha.L[peredacha.i] = 350;
							}
							if (peredacha.OprShirremCKH_40[peredacha.i] == "20")
							{
								peredacha.L[peredacha.i] = 500;
							}
							if (peredacha.OprShirremCKH_40[peredacha.i] == "25")
							{
								peredacha.L[peredacha.i] = 710;
							}
							if (peredacha.OprShirremCKH_40[peredacha.i] == "30")
							{
								peredacha.L[peredacha.i] = 1000;
							}
						}
						if (peredacha.MatVid[peredacha.i] == "Капроновая ткань на основе двухточной саржи, покрытая наиритовым латексом")
						{
							if (peredacha.OprShirremSar[peredacha.i] == "40")
							{
								peredacha.L[peredacha.i] = 1500;
							}
							if (peredacha.OprShirremSar[peredacha.i] == "50")
							{
								peredacha.L[peredacha.i] = 2120; 
							}
							if (peredacha.OprShirremSar[peredacha.i] == "60")
							{
								peredacha.L[peredacha.i] = 2120;
							}
							if (peredacha.OprShirremSar[peredacha.i] == "80")
							{
								peredacha.L[peredacha.i] = 3550;
							}
							if (peredacha.OprShirremSar[peredacha.i] == "100")
							{
								peredacha.L[peredacha.i] = 3550;
							}
						}
					}
				}
			}
			if (peredacha.SposobL[peredacha.i] == "b) Минимальной длины ремня из условий сравнительной долговечности ремня")
			{
				peredacha.L[peredacha.i] = peredacha.v[peredacha.i] / peredacha.nchastots[peredacha.i];
			}
			textBox16.Text = Convert.ToString(peredacha.L[peredacha.i]); //тут кидаем в длину


		}
		public void CalculationAmin()
		{
			peredacha.amin[peredacha.i] = peredacha.K[peredacha.i] * (peredacha.D1[peredacha.i] + peredacha.D2[peredacha.i]);
			textBox14.Text = Convert.ToString(peredacha.amin[peredacha.i]);
			
		}
		public void CalculationD2() // D2 считает правильно
		{
			peredacha.n2[peredacha.i] = Convert.ToDouble(textBox4.Text);
			peredacha.u[peredacha.i] = peredacha.n1[peredacha.i] / peredacha.n2[peredacha.i];
			textBox12.Text = Convert.ToString(peredacha.u[peredacha.i]);
			peredacha.E[peredacha.i] = Convert.ToDouble(textBox5.Text);
			peredacha.D2[peredacha.i] = 0;
			peredacha.VidPer[peredacha.i] = comboBox7.Text;
			double Df = 0;

			if (peredacha.VidPer[peredacha.i]== "Повышающая передача")
			{
				Df = peredacha.D1[peredacha.i] * peredacha.u[peredacha.i] / (1 - peredacha.E[peredacha.i]);
			}
			if (peredacha.VidPer[peredacha.i] == "Понижающая передача")
			{
				Df = peredacha.D1[peredacha.i] * (1 - peredacha.E[peredacha.i]) * peredacha.u[peredacha.i];
			}

			peredacha.D2[peredacha.i] = Drounding(Df);

			textBox13.Text = Convert.ToString(peredacha.D2[peredacha.i]);
		}
		public void DeterminationOfTheCoefficient()
		{
			VDeterminingBeltSpeed();
			if (peredacha.v[peredacha.i] < 30)
			{
				peredacha.K[peredacha.i] = 2;
				
			}
			if ((30 < peredacha.v[peredacha.i]) && (peredacha.v[peredacha.i] < 50))
			{
				peredacha.K[peredacha.i] = 1.5;
			}
			textBox15.Text = Convert.ToString(peredacha.K[peredacha.i]);
		}
		public void VDeterminingBeltSpeed() // скорость правильно
		{
			
			peredacha.n1[peredacha.i] = Convert.ToDouble(textBox1.Text);
			peredacha.v[peredacha.i] = Math.PI * peredacha.D1[peredacha.i] * peredacha.n1[peredacha.i] / (Math.Pow(10, 3) * 60); // нашли скорость ремня
			textBox11.Text = Convert.ToString(peredacha.v[peredacha.i]);

		}
		public double CalculationD1() // расчёт D1
		{
			double D1f = 0; // чему в конце будет равнять D1
			double D1Final = 0; // финальное значение D1 которое будет возвращать функция
			if (peredacha.abvg[peredacha.i] == "a)")
			{
				D1f = D1ofTheSmallerPulleyAccordingToTheSaverinFormula(); // Опредедение диаметра меньшего шкива по форумле саверина, D1 (mm) (возвращает своё D1)
			}
			if (peredacha.abvg[peredacha.i] == "b)")
			{
				D1f = D1DeterminingTheDiameterOfTheSmallerPulleyBasedOnTheApproximateBeltSpeed();
			}
			if (peredacha.abvg[peredacha.i] == "v)")
			{
				D1f = D1DeterminationOfTheDiameterOfTheSmallerPulleyBasedOnDesignConsiderationsBasedOnTheDimensionsOfTheInstallation();
			}
			if (peredacha.abvg[peredacha.i] == "g)")
			{
				D1f = D1DeterminationOfTheDiameterOfTheSmallerPulleyDependingOnTheTypeAndThicknessOfTheBelt();
			}
			//функция которая приводит к нужному значению по таблице 5(13.18)
			D1f = Drounding(D1f);
			


			peredacha.D1[peredacha.i] = D1f;
			VDeterminingBeltSpeed(); // определяем скорость
			return D1Final; // возврашаем финальное значение D1
		}

		public double Drounding(double Df)//округление D1
		{
			if(Df>=315)//больше стандартного
			{
				Df = 315;
			}
			if(Df<=63)//меньше стандартного
			{
				Df = 63;
			}
			if((Df<315)&&(Df>63))// ныряет в диапозон
			{
				if((Df < 71) && (Df > 63)) // округление в большую сторону
				{
					double sr = (71 + 63) / 2;
					if(Df<sr)
					{
						Df = 63;
					}
					if(Df>=sr)
					{
						Df = 71;
					}
				}
				if ((Df < 80) && (Df > 71))
				{
					double sr = (71 + 80) / 2;
					if (Df < sr)
					{
						Df = 71;
					}
					if (Df >= sr)
					{
						Df = 80;
					}
				}
				if ((Df < 90) && (Df > 80))
				{
					double sr = (90 + 80) / 2;
					if (Df < sr)
					{
						Df = 80;
					}
					if (Df >= sr)
					{
						Df = 90;
					}
				}
				if ((Df < 100) && (Df > 90))
				{
					double sr = (90 + 100) / 2;
					if (Df < sr)
					{
						Df = 90;
					}
					if (Df >= sr)
					{
						Df = 100;
					}
				}
				if ((Df < 112) && (Df > 100))
				{
					double sr = (100 + 112) / 2;
					if (Df < sr)
					{
						Df = 100;
					}
					if (Df >= sr)
					{
						Df = 112;
					}
				}
				if ((Df < 125) && (Df > 112))
				{
					double sr = (125 + 112) / 2;
					if (Df < sr)
					{
						Df = 112;
					}
					if (Df >= sr)
					{
						Df = 125;
					}
				}
				if ((Df < 140) && (Df > 125))
				{
					double sr = (125 + 140) / 2;
					if (Df < sr)
					{
						Df = 125;
					}
					if (Df >= sr)
					{
						Df = 140;
					}
				}
				if ((Df < 160) && (Df > 140))
				{
					double sr = (160 + 140) / 2;
					if (Df < sr)
					{
						Df = 140;
					}
					if (Df >= sr)
					{
						Df = 160;
					}
				}
				if ((Df < 180) && (Df > 160))
				{
					double sr = (160 + 180) / 2;
					if (Df < sr)
					{
						Df = 160;
					}
					if (Df >= sr)
					{
						Df = 180;
					}
				}
				if ((Df < 200) && (Df > 180))
				{
					double sr = (200 + 180) / 2;
					if (Df < sr)
					{
						Df = 180;
					}
					if (Df >= sr)
					{
						Df = 200;
					}
				}
				if ((Df < 224) && (Df > 200))
				{
					double sr = (200 + 224) / 2;
					if (Df < sr)
					{
						Df = 200;
					}
					if (Df >= sr)
					{
						Df = 224;
					}
				}
				if ((Df < 250) && (Df > 224))
				{
					double sr = (250 + 224) / 2;
					if (Df < sr)
					{
						Df = 224;
					}
					if (Df >= sr)
					{
						Df = 250;
					}
				}
				if ((Df < 280) && (Df > 250))
				{
					double sr = (250 + 280) / 2;
					if (Df < sr)
					{
						Df = 250;
					}
					if (Df >= sr)
					{
						Df = 280;
					}
				}
				if ((Df < 315) && (Df > 280))
				{
					double sr = (315 + 280) / 2;
					if (Df < sr)
					{
						Df = 280;
					}
					if (Df >= sr)
					{
						Df = 315;
					}
				}
			}

			return Df;
		}
		public double D1ofTheSmallerPulleyAccordingToTheSaverinFormula() // D1 саверин считает правильно
		{
			
			//
			peredacha.Kp[peredacha.i] = Convert.ToDouble(textBox19.Text);
			double Kp = peredacha.Kp[peredacha.i];
			double D1_ = 0;
			peredacha.N[peredacha.i] = Convert.ToDouble(textBoxx2.Text); // получаем значение мощности
			peredacha.n1[peredacha.i] = Convert.ToDouble(textBox1.Text); // получаем значение частоты вращения на меньшем шкиве
																		 //peredacha.D1a[peredacha.i] = 130 * Math.Pow((peredacha.N[peredacha.i] * Math.Pow(10, 3.0)) / peredacha.n1[peredacha.i], 1 / 3.0); // запятая?
																		 //тест
																		 //peredacha.D1a[peredacha.i] = 130 * Math.Pow((peredacha.N[peredacha.i] * (Math.Pow(10, 3.0) / peredacha.n1[peredacha.i])), 1 / 3.0);
			double x = peredacha.N[peredacha.i] * (Math.Pow(10, 3.0)) / peredacha.n1[peredacha.i];
			peredacha.D1a[peredacha.i] = Kp * Math.Pow(x, 1 / 3.0); // тут нужен подгоночеый коэффициент
			// суём в вывод для просмотра
			textBox7.Text = Convert.ToString(peredacha.D1a[peredacha.i]);

			return D1_ = peredacha.D1a[peredacha.i];
		}
		public double D1DeterminingTheDiameterOfTheSmallerPulleyBasedOnTheApproximateBeltSpeed()
		{
			double D1b_;
			double v = 0; // скорость по таблице
			peredacha.VidRem[peredacha.i] = comboBox2.Text;
			peredacha.n1[peredacha.i] = Convert.ToDouble(textBox1.Text);
			if (peredacha.VidRem[peredacha.i] == "Тканевые прорезиненные конечной длины")
			{
				v = 30;
			}
			if (peredacha.VidRem[peredacha.i] == "Синтетические капроновые с плёночным покрытием 'Тип 1'")
			{
				v = 100;
			}
			if (peredacha.VidRem[peredacha.i] == "Синтетические капроновые с плёночным покрытием 'Тип 2'")
			{
				v = 50;
			}
			peredacha.D1b[peredacha.i] = v / (Math.PI * (peredacha.n1[peredacha.i] / (Math.Pow(10, 3) * 60))); // проверить так ли

			// суём в вывод для просмотра
			textBox8.Text = Convert.ToString(peredacha.D1b[peredacha.i]);
			D1b_ = peredacha.D1b[peredacha.i];

			return D1b_;
		}
		public double D1DeterminationOfTheDiameterOfTheSmallerPulleyBasedOnDesignConsiderationsBasedOnTheDimensionsOfTheInstallation()
		{
			//Добвленно для отладки
			DeterminationOfTheCoefficient();


			peredacha.D1v[peredacha.i] = Convert.ToDouble(textBox2.Text);
			textBox9.Text = Convert.ToString(peredacha.D1v[peredacha.i]);
			double D1v_ = peredacha.D1v[peredacha.i];
			
			return D1v_;
		}
		public double D1DeterminationOfTheDiameterOfTheSmallerPulleyDependingOnTheTypeAndThicknessOfTheBelt()
		{
			double D1g = 0;
			string rekAndDop = comboBox12.Text;
			peredacha.VidRem[peredacha.i] = comboBox2.Text;
			peredacha.VidTKA[peredacha.i] = comboBox3.Text;
			peredacha.prok[peredacha.i] = Convert.ToDouble(comboBox4.Text);
			peredacha.prosnal[peredacha.i] = comboBox5.Text;
			peredacha.Del[peredacha.i] = Convert.ToDouble(comboBox6.Text);
			//  рекомендованные
			//допускаемые
			
			if (peredacha.VidRem[peredacha.i] == "Тканевые прорезиненные конечной длины") // беру наибольшее значение
			{

				if (rekAndDop == "рекомендованные")
				{
					if (peredacha.VidTKA[peredacha.i] == "Б-800, Б-820")
					{
						if (peredacha.prosnal[peredacha.i] == "С прослойками")
						{
							if (peredacha.prok[peredacha.i] == 3)
							{
								peredacha.D1g[peredacha.i] = 180;
							}
							if (peredacha.prok[peredacha.i] == 4)
							{
								peredacha.D1g[peredacha.i] = 224;
							}
							if (peredacha.prok[peredacha.i] == 5)
							{
								peredacha.D1g[peredacha.i] = 315;
							}
							if (peredacha.prok[peredacha.i] == 6)
							{
								peredacha.D1g[peredacha.i] = 355;
							}
						}
						if (peredacha.prosnal[peredacha.i] == "Без прослоек")
						{
							if (peredacha.prok[peredacha.i] == 3)
							{
								peredacha.D1g[peredacha.i] = 140; //140/112
							}
							if (peredacha.prok[peredacha.i] == 4)
							{
								peredacha.D1g[peredacha.i] = 200; //200/140
							}
							if (peredacha.prok[peredacha.i] == 5)
							{
								peredacha.D1g[peredacha.i] = 250; //250/180
							}
							if (peredacha.prok[peredacha.i] == 6)
							{
								peredacha.D1g[peredacha.i] = 315; //315/224
							}
						}

					}
					if (peredacha.VidTKA[peredacha.i] == "БКНЛ-65, БКНЛ-65-2")
					{
						if (peredacha.prosnal[peredacha.i] == "С прослойками")
						{
							if (peredacha.prok[peredacha.i] == 3)
							{
								peredacha.D1g[peredacha.i] = 140;//140/112
							}
							if (peredacha.prok[peredacha.i] == 4)
							{
								peredacha.D1g[peredacha.i] = 180;//180/140
							}
							if (peredacha.prok[peredacha.i] == 5)
							{
								peredacha.D1g[peredacha.i] = 224;//224/180
							}
							if (peredacha.prok[peredacha.i] == 6)
							{
								peredacha.D1g[peredacha.i] = 280;//280/200
							}
						}
						if (peredacha.prosnal[peredacha.i] == "Без прослоек")
						{
							if (peredacha.prok[peredacha.i] == 3)
							{
								peredacha.D1g[peredacha.i] = 125;//125/90
							}
							if (peredacha.prok[peredacha.i] == 4)
							{
								peredacha.D1g[peredacha.i] = 160;//160/112
							}
							if (peredacha.prok[peredacha.i] == 5)
							{
								peredacha.D1g[peredacha.i] = 200;//200/140
							}
							if (peredacha.prok[peredacha.i] == 6)
							{
								peredacha.D1g[peredacha.i] = 224;//224/180
							}
						}
					}
				}
				if (rekAndDop == "допускаемые")
				{
					if (peredacha.VidTKA[peredacha.i] == "Б-800, Б-820")
					{
						if (peredacha.prosnal[peredacha.i] == "С прослойками")
						{
							if (peredacha.prok[peredacha.i] == 3)
							{
								peredacha.D1g[peredacha.i] = 140;
							}
							if (peredacha.prok[peredacha.i] == 4)
							{
								peredacha.D1g[peredacha.i] = 180;
							}
							if (peredacha.prok[peredacha.i] == 5)
							{
								peredacha.D1g[peredacha.i] = 224;
							}
							if (peredacha.prok[peredacha.i] == 6)
							{
								peredacha.D1g[peredacha.i] = 315;
							}
						}
						if (peredacha.prosnal[peredacha.i] == "Без прослоек")
						{
							if (peredacha.prok[peredacha.i] == 3)
							{
								peredacha.D1g[peredacha.i] = 112; //140/112
							}
							if (peredacha.prok[peredacha.i] == 4)
							{
								peredacha.D1g[peredacha.i] = 140; //200/140
							}
							if (peredacha.prok[peredacha.i] == 5)
							{
								peredacha.D1g[peredacha.i] = 180; //250/180
							}
							if (peredacha.prok[peredacha.i] == 6)
							{
								peredacha.D1g[peredacha.i] = 224; //315/224
							}
						}

					}
					if (peredacha.VidTKA[peredacha.i] == "БКНЛ-65, БКНЛ-65-2")
					{
						if (peredacha.prosnal[peredacha.i] == "С прослойками")
						{
							if (peredacha.prok[peredacha.i] == 3)
							{
								peredacha.D1g[peredacha.i] = 112;//140/112
							}
							if (peredacha.prok[peredacha.i] == 4)
							{
								peredacha.D1g[peredacha.i] = 140;//180/140
							}
							if (peredacha.prok[peredacha.i] == 5)
							{
								peredacha.D1g[peredacha.i] = 180;//224/180
							}
							if (peredacha.prok[peredacha.i] == 6)
							{
								peredacha.D1g[peredacha.i] = 200;//280/200
							}
						}
						if (peredacha.prosnal[peredacha.i] == "Без прослоек")
						{
							if (peredacha.prok[peredacha.i] == 3)
							{
								peredacha.D1g[peredacha.i] = 90;//125/90
							}
							if (peredacha.prok[peredacha.i] == 4)
							{
								peredacha.D1g[peredacha.i] = 112;//160/112
							}
							if (peredacha.prok[peredacha.i] == 5)
							{
								peredacha.D1g[peredacha.i] = 140;//200/140
							}
							if (peredacha.prok[peredacha.i] == 6)
							{
								peredacha.D1g[peredacha.i] = 180;//224/180
							}
						}
					}
				}
			}
			else // синтеттические ремни
			{
				if (peredacha.Del[peredacha.i] == 0.4)
				{
					peredacha.D1g[peredacha.i] = 28;
				}
				if (peredacha.Del[peredacha.i] == 0.5)
				{
					peredacha.D1g[peredacha.i] = 36;
				}
				if (peredacha.Del[peredacha.i] == 0.6)
				{
					peredacha.D1g[peredacha.i] = 45;
				}
				if (peredacha.Del[peredacha.i] == 0.7)
				{
					peredacha.D1g[peredacha.i] = 56;
				}
				if (peredacha.Del[peredacha.i] == 0.8)
				{
					peredacha.D1g[peredacha.i] = 63;
				}
				if (peredacha.Del[peredacha.i] == 0.9)
				{
					peredacha.D1g[peredacha.i] = 71;
				}
				if (peredacha.Del[peredacha.i] == 1.0)
				{
					peredacha.D1g[peredacha.i] = 80;
				}
				if (peredacha.Del[peredacha.i] == 1.1)
				{
					peredacha.D1g[peredacha.i] = 90;
				}
				if (peredacha.Del[peredacha.i] == 1.2)
				{
					peredacha.D1g[peredacha.i] = 100;
				}
			}
			D1g = peredacha.D1g[peredacha.i];
			textBox10.Text = Convert.ToString(peredacha.D1g[peredacha.i]);
			return D1g;

		}




		public void tbl()
		{
			// таблица 
			dataGridView1.RowCount = 2; // строки
			dataGridView1.ColumnCount = peredacha.i + 1; // столбцы
			dataGridView1.Rows[0].Cells[0].Value = "Передача";
			dataGridView1.Rows[1].Cells[0].Value = "a1";
			for (int j = 1; j <= peredacha.i; j++)
			{
				dataGridView1.Rows[0].Cells[j].Value = j.ToString();
				dataGridView1.Rows[1].Cells[j].Value = peredacha.a1[j];
			}
			//
		}


		private void label7_Click(object sender, EventArgs e)
		{
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form2 newForm = new Form2(peredacha);
			newForm.Show();
		}

		private void button3_Click(object sender, EventArgs e) // удаление передачи 
		{
			int ydl_ = Convert.ToInt32(ydl.Text); // индекс передачи которую удаляем
			Peredacha p = peredacha;

			if (peredacha.i != 1)
			{
				for (int r = ydl_; r < p.i; r++)
				{
					p.abvg[r] = p.abvg[r + 1];
					p.N[r] = p.N[r + 1];
					p.n1[r] = p.n1[r + 1];
					p.VidRem[r] = p.VidRem[r + 1];
					p.VidTKA[r] = p.VidTKA[r + 1];
					p.prok[r] = p.prok[r + 1];
					p.b[r] = p.b[r + 1];
					p.prosnal[r] = p.prosnal[r + 1];
					p.Del[r] = p.Del[r + 1];
					p.n2[r] = p.n2[r + 1];
					p.E[r] = p.E[r + 1];
					p.VidPer[r] = p.VidPer[r + 1];
					p.SposobL[r] = p.SposobL[r + 1];
					p.nchastots[r] = p.nchastots[r + 1];
					p.MatVid[r] = p.MatVid[r + 1];
					p.OprShirremCKH_40[r] = p.OprShirremCKH_40[r + 1];
					p.OprShirremSar[r] = p.OprShirremSar[r + 1];
					//
					p.D1a[r] = p.D1a[r + 1];
					p.D1b[r] = p.D1b[r + 1];
					p.D1v[r] = p.D1v[r + 1];
					p.D1g[r] = p.D1g[r + 1];
					p.D1[r] = p.D1[r + 1];
					p.v[r] = p.v[r + 1];
					p.u[r] = p.v[r + 1];
					p.D2[r] = p.D2[r + 1];
					p.amin[r] = p.amin[r + 1];
					p.K[r] = p.K[r + 1];
					p.L[r] = p.L[r + 1];
					p.a[r] = p.a[r + 1];
					p.a1[r] = p.a1[r + 1];
					//

				}
				p.i--;
				//InitializeComponent();
				dataGridView1.RowCount = p.i + 1;
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
				dataGridView1.Rows[0].Cells[19].Value = "D1"; // определение ширин ыремня CKH-40
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

				tbl(); // удаление передачи в маленькой таблице которое не получается(

			}
			// удаление одной передачи
			else
			{
				int r = 1;
				p.abvg[r] = p.abvg[r + 1];
				p.N[r] = p.N[r + 1];
				p.n1[r] = p.n1[r + 1];
				p.VidRem[r] = p.VidRem[r + 1];
				p.VidTKA[r] = p.VidTKA[r + 1];
				p.prok[r] = p.prok[r + 1];
				p.b[r] = p.b[r + 1];
				p.prosnal[r] = p.prosnal[r + 1];
				p.Del[r] = p.Del[r + 1];
				p.n2[r] = p.n2[r + 1];
				p.E[r] = p.E[r + 1];
				p.VidPer[r] = p.VidPer[r + 1];
				p.SposobL[r] = p.SposobL[r + 1];
				p.nchastots[r] = p.nchastots[r + 1];
				p.MatVid[r] = p.MatVid[r + 1];
				p.OprShirremCKH_40[r] = p.OprShirremCKH_40[r + 1];
				p.OprShirremSar[r] = p.OprShirremSar[r + 1];
				//
				p.D1a[r] = p.D1a[r + 1];
				p.D1b[r] = p.D1b[r + 1];
				p.D1v[r] = p.D1v[r + 1];
				p.D1g[r] = p.D1g[r + 1];
				p.D1[r] = p.D1[r + 1];
				p.v[r] = p.v[r + 1];
				p.u[r] = p.v[r + 1];
				p.D2[r] = p.D2[r + 1];
				p.amin[r] = p.amin[r + 1];
				p.K[r] = p.K[r + 1];
				p.L[r] = p.L[r + 1];
				p.a[r] = p.a[r + 1];
				p.a1[r] = p.a1[r + 1];
				//

			
			p.i--;
			//InitializeComponent();
			dataGridView1.RowCount = p.i + 1;
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
			dataGridView1.Rows[0].Cells[19].Value = "D1"; // определение ширин ыремня CKH-40
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
		    }

			

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void ydl_TextChanged(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void label10_Click_1(object sender, EventArgs e)
		{

		}

		private void label14_Click(object sender, EventArgs e)
		{

		}

		private void label23_Click(object sender, EventArgs e)
		{

		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBoxa1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label27_Click(object sender, EventArgs e)
		{

		}

		private void label29_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click_1(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)// просмотр всех таблиц
		{
			Form3 form3 = new Form3();
			form3.Show();
		}

		private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox11_TextChanged(object sender, EventArgs e)
		{

		}

		private void label21_Click(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
