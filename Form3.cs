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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();

			#region  таблица №1
			dataGridView1.RowCount = 44;
			dataGridView1.ColumnCount = 3;
			//столбец 0 
			dataGridView1.Rows[0].Cells[0].Value = "Наименование параметра";
			dataGridView1.Rows[1].Cells[0].Value = "Ширина";
			dataGridView1.Rows[2].Cells[0].Value = "Ширина";
			dataGridView1.Rows[3].Cells[0].Value = "Ширина";
			dataGridView1.Rows[4].Cells[0].Value = "Толщина";
			dataGridView1.Rows[5].Cells[0].Value = "Толщина";
			dataGridView1.Rows[6].Cells[0].Value = "Толщина";
			dataGridView1.Rows[7].Cells[0].Value = "Рекомендуемая наибольшая скорость v, м/с";
			dataGridView1.Rows[8].Cells[0].Value = "Рекомендуемая наибольшая скорость v, м/с";
			dataGridView1.Rows[9].Cells[0].Value = "Рекомендуемая наибольшая скорость v, м/с";
			dataGridView1.Rows[10].Cells[0].Value = "Передаваемые нагрузки";
			dataGridView1.Rows[11].Cells[0].Value = "Передаваемые нагрузки";
			dataGridView1.Rows[12].Cells[0].Value = "Передаваемые нагрузки";
			dataGridView1.Rows[13].Cells[0].Value = "Удельная тяговая способность";
			dataGridView1.Rows[14].Cells[0].Value = "Удельная тяговая способность";
			dataGridView1.Rows[15].Cells[0].Value = "Удельная тяговая способность";
			dataGridView1.Rows[16].Cells[0].Value = "Допускаемые кратковремнные перегрузки";
			dataGridView1.Rows[17].Cells[0].Value = "Допускаемые кратковремнные перегрузки";
			dataGridView1.Rows[18].Cells[0].Value = "Допускаемые кратковремнные перегрузки";
			dataGridView1.Rows[19].Cells[0].Value = "Долговечность";
			dataGridView1.Rows[20].Cells[0].Value = "Долговечность";
			dataGridView1.Rows[21].Cells[0].Value = "Долговечность";
			dataGridView1.Rows[22].Cells[0].Value = "Предел прочности при растяжении, без прослоек, МПа";
			dataGridView1.Rows[23].Cells[0].Value = "Предел прочности при растяжении, с прослойками, МПа";
			dataGridView1.Rows[24].Cells[0].Value = "Предел прочности при растяжении, МПа";
			dataGridView1.Rows[25].Cells[0].Value = "Предел прочности при растяжении, МПа";
			dataGridView1.Rows[26].Cells[0].Value = "Модули упругости, Мпа (при растяжении Ep)";
			dataGridView1.Rows[27].Cells[0].Value = "Модули упругости, Мпа (при изгибе Eи)";
			dataGridView1.Rows[28].Cells[0].Value = "Модули упругости, Мпа (при растяжении Ep)";
			dataGridView1.Rows[29].Cells[0].Value = "Модули упругости, Мпа (при изгибе Eи)";
			dataGridView1.Rows[30].Cells[0].Value = "Модули упругости, Мпа (при растяжении Ep)";
			dataGridView1.Rows[31].Cells[0].Value = "Модули упругости, Мпа (при изгибе Eи)";
			dataGridView1.Rows[32].Cells[0].Value = "Удлинение при разрыве, %, не более";
			dataGridView1.Rows[33].Cells[0].Value = "Удлинение при разрыве, %, не более";
			dataGridView1.Rows[34].Cells[0].Value = "Удлинение при разрыве, %, не более";
			dataGridView1.Rows[35].Cells[0].Value = "Плотность ремня р, кг/м^3";
			dataGridView1.Rows[36].Cells[0].Value = "Плотность ремня р, кг/м^3";
			dataGridView1.Rows[37].Cells[0].Value = "Плотность ремня р, кг/м^3";
			dataGridView1.Rows[38].Cells[0].Value = "Отношение диаметра меньшего шкива к толщине ремня D/δ, допускаемое";
			dataGridView1.Rows[39].Cells[0].Value = "Отношение диаметра меньшего шкива к толщине ремня D/δ, допускаемое";
			dataGridView1.Rows[40].Cells[0].Value = "Отношение диаметра меньшего шкива к толщине ремня D/δ, допускаемое";
			dataGridView1.Rows[41].Cells[0].Value = "Отношение диаметра меньшего шкива к толщине ремня D/δ, рекомендуемое";
			dataGridView1.Rows[42].Cells[0].Value = "Отношение диаметра меньшего шкива к толщине ремня D/δ, рекомендуемое";
			dataGridView1.Rows[43].Cells[0].Value = "Отношение диаметра меньшего шкива к толщине ремня D/δ, рекомендуемое";
			// столбец 1
			dataGridView1.Rows[0].Cells[1].Value = "Тканевые прорезиненные конечной длины или синтетические капроновые с пленочным покрытием (“Тип 1” или “Тип 2”)";
			dataGridView1.Rows[1].Cells[1].Value = "Тканевые прорезиненные конечной длины";
			dataGridView1.Rows[2].Cells[1].Value = "Тип 1";
			dataGridView1.Rows[3].Cells[1].Value = "Тип 2";
			dataGridView1.Rows[4].Cells[1].Value = "Тканевые прорезиненные конечной длины";
			dataGridView1.Rows[5].Cells[1].Value = "Тип 1";
			dataGridView1.Rows[6].Cells[1].Value = "Тип 2";
			dataGridView1.Rows[7].Cells[1].Value = "Тканевые прорезиненные конечной длины";
			dataGridView1.Rows[8].Cells[1].Value = "Тип 1";
			dataGridView1.Rows[9].Cells[1].Value = "Тип 2";
			dataGridView1.Rows[10].Cells[1].Value = "Тканевые прорезиненные конечной длины";
			dataGridView1.Rows[11].Cells[1].Value = "Тип 1";
			dataGridView1.Rows[12].Cells[1].Value = "Тип 2";
			dataGridView1.Rows[13].Cells[1].Value = "Тканевые прорезиненные конечной длины";
			dataGridView1.Rows[14].Cells[1].Value = "Тип 1";
			dataGridView1.Rows[15].Cells[1].Value = "Тип 2";
			dataGridView1.Rows[16].Cells[1].Value = "Тканевые прорезиненные конечной длины";
			dataGridView1.Rows[17].Cells[1].Value = "Тип 1";
			dataGridView1.Rows[18].Cells[1].Value = "Тип 2";
			dataGridView1.Rows[19].Cells[1].Value = "Тканевые прорезиненные конечной длины";
			dataGridView1.Rows[20].Cells[1].Value = "Тип 1";
			dataGridView1.Rows[21].Cells[1].Value = "Тип 2";
			dataGridView1.Rows[22].Cells[1].Value = "Тканевые прорезиненные конечной длины";
			dataGridView1.Rows[23].Cells[1].Value = "Тканевые прорезиненные конечной длины";
			dataGridView1.Rows[24].Cells[1].Value = "Тип 1";
			dataGridView1.Rows[25].Cells[1].Value = "Тип 2";
			dataGridView1.Rows[26].Cells[1].Value = "Тканевые прорезиненные конечной длины";
			dataGridView1.Rows[27].Cells[1].Value = "Тканевые прорезиненные конечной длины";
			dataGridView1.Rows[28].Cells[1].Value = "Тип 1";
			dataGridView1.Rows[29].Cells[1].Value = "Тип 1";
			dataGridView1.Rows[30].Cells[1].Value = "Тип 2";
			dataGridView1.Rows[31].Cells[1].Value = "Тип 2";
			dataGridView1.Rows[32].Cells[1].Value = "Тканевые прорезиненные конечной длины";
			dataGridView1.Rows[33].Cells[1].Value = "Тип 1";
			dataGridView1.Rows[34].Cells[1].Value = "Тип 2";
			dataGridView1.Rows[35].Cells[1].Value = "Тканевые прорезиненные конечной длины";
			dataGridView1.Rows[36].Cells[1].Value = "Тип 1";
			dataGridView1.Rows[37].Cells[1].Value = "Тип 2";
			dataGridView1.Rows[38].Cells[1].Value = "Тканевые прорезиненные конечной длины";
			dataGridView1.Rows[39].Cells[1].Value = "Тип 1";
			dataGridView1.Rows[40].Cells[1].Value = "Тип 2";
			dataGridView1.Rows[41].Cells[1].Value = "Тканевые прорезиненные конечной длины";
			dataGridView1.Rows[42].Cells[1].Value = "Тип 1";
			dataGridView1.Rows[43].Cells[1].Value = "Тип 2";
			// столбец 2
			dataGridView1.Rows[0].Cells[2].Value = "Значение параметра";
			dataGridView1.Rows[1].Cells[2].Value = "20…500";
			dataGridView1.Rows[2].Cells[2].Value = "10…30";
			dataGridView1.Rows[3].Cells[2].Value = "40…100";
			dataGridView1.Rows[4].Cells[2].Value = "3…13,5";
			dataGridView1.Rows[5].Cells[2].Value = "10…30";
			dataGridView1.Rows[6].Cells[2].Value = "40…100";
			dataGridView1.Rows[7].Cells[2].Value = "30";
			dataGridView1.Rows[8].Cells[2].Value = "100";
			dataGridView1.Rows[9].Cells[2].Value = "50";
			dataGridView1.Rows[10].Cells[2].Value = "Малые, средние, большие";
			dataGridView1.Rows[11].Cells[2].Value = "Малые";
			dataGridView1.Rows[12].Cells[2].Value = "Малые, Средние";
			dataGridView1.Rows[13].Cells[2].Value = "Высокая";
			dataGridView1.Rows[14].Cells[2].Value = "Средняя";
			dataGridView1.Rows[15].Cells[2].Value = "Высокая";
			dataGridView1.Rows[16].Cells[2].Value = "<1,3";
			dataGridView1.Rows[17].Cells[2].Value = "<1,2";
			dataGridView1.Rows[18].Cells[2].Value = "<1,3";
			dataGridView1.Rows[19].Cells[2].Value = "Средняя";
			dataGridView1.Rows[20].Cells[2].Value = "Высокая";
			dataGridView1.Rows[21].Cells[2].Value = "Высокая";
			dataGridView1.Rows[22].Cells[2].Value = "~44";
			dataGridView1.Rows[23].Cells[2].Value = "~37";
			dataGridView1.Rows[24].Cells[2].Value = "~120…150";
			dataGridView1.Rows[25].Cells[2].Value = "~150";
			dataGridView1.Rows[26].Cells[2].Value = "~200";
			dataGridView1.Rows[27].Cells[2].Value = "~140";
			dataGridView1.Rows[28].Cells[2].Value = "~10^3";
			dataGridView1.Rows[29].Cells[2].Value = "~0.5 * 10^3";
			dataGridView1.Rows[30].Cells[2].Value = "~10^3";
			dataGridView1.Rows[31].Cells[2].Value = "~0.5 * 10^3";
			dataGridView1.Rows[32].Cells[2].Value = "18";
			dataGridView1.Rows[33].Cells[2].Value = "25";
			dataGridView1.Rows[34].Cells[2].Value = "25";
			dataGridView1.Rows[35].Cells[2].Value = "1,25*10^3…1,5*10^3";
			dataGridView1.Rows[36].Cells[2].Value = "0,6*10^3";
			dataGridView1.Rows[37].Cells[2].Value = "1,2*10^3";
			dataGridView1.Rows[38].Cells[2].Value = "30";
			dataGridView1.Rows[39].Cells[2].Value = "50…70";
			dataGridView1.Rows[40].Cells[2].Value = "50…70";
			dataGridView1.Rows[41].Cells[2].Value = "40";
			dataGridView1.Rows[42].Cells[2].Value = "100…150";
			dataGridView1.Rows[43].Cells[2].Value = "100…150";
			#endregion
			#region таблица №2
			dataGridView2.RowCount = 42;
			dataGridView2.ColumnCount = 7;
			//столбец 0 
			dataGridView2.Rows[0].Cells[0].Value = "Тип ремня";
			dataGridView2.Rows[1].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[2].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[3].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[4].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[5].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[6].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[7].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[8].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[9].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[10].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[11].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[12].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[13].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[14].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[15].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[16].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[17].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[18].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[19].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[20].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[21].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[22].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[23].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[24].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[25].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[26].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[27].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[28].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[29].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[30].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[31].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[32].Cells[0].Value = "Прорезиненный ремень";
			dataGridView2.Rows[33].Cells[0].Value = "Синтетический ремень";
			dataGridView2.Rows[34].Cells[0].Value = "Синтетический ремень";
			dataGridView2.Rows[35].Cells[0].Value = "Синтетический ремень";
			dataGridView2.Rows[36].Cells[0].Value = "Синтетический ремень";
			dataGridView2.Rows[37].Cells[0].Value = "Синтетический ремень";
			dataGridView2.Rows[38].Cells[0].Value = "Синтетический ремень";
			dataGridView2.Rows[39].Cells[0].Value = "Синтетический ремень";
			dataGridView2.Rows[40].Cells[0].Value = "Синтетический ремень";
			dataGridView2.Rows[41].Cells[0].Value = "Синтетический ремень";
			// столбец 1
			dataGridView2.Rows[0].Cells[1].Value = "Число прокладок";
			dataGridView2.Rows[1].Cells[1].Value = "3";
			dataGridView2.Rows[2].Cells[1].Value = "3";
			dataGridView2.Rows[3].Cells[1].Value = "3";
			dataGridView2.Rows[4].Cells[1].Value = "3";
			dataGridView2.Rows[5].Cells[1].Value = "4";
			dataGridView2.Rows[6].Cells[1].Value = "4";
			dataGridView2.Rows[7].Cells[1].Value = "4";
			dataGridView2.Rows[8].Cells[1].Value = "4";
			dataGridView2.Rows[9].Cells[1].Value = "5";
			dataGridView2.Rows[10].Cells[1].Value = "5";
			dataGridView2.Rows[11].Cells[1].Value = "5";
			dataGridView2.Rows[12].Cells[1].Value = "5";
			dataGridView2.Rows[13].Cells[1].Value = "6";
			dataGridView2.Rows[14].Cells[1].Value = "6";
			dataGridView2.Rows[15].Cells[1].Value = "6";
			dataGridView2.Rows[16].Cells[1].Value = "6";
			dataGridView2.Rows[17].Cells[1].Value = "3";
			dataGridView2.Rows[18].Cells[1].Value = "3";
			dataGridView2.Rows[19].Cells[1].Value = "3";
			dataGridView2.Rows[20].Cells[1].Value = "3";
			dataGridView2.Rows[21].Cells[1].Value = "4";
			dataGridView2.Rows[22].Cells[1].Value = "4";
			dataGridView2.Rows[23].Cells[1].Value = "4";
			dataGridView2.Rows[24].Cells[1].Value = "4";
			dataGridView2.Rows[25].Cells[1].Value = "5";
			dataGridView2.Rows[26].Cells[1].Value = "5";
			dataGridView2.Rows[27].Cells[1].Value = "5";
			dataGridView2.Rows[28].Cells[1].Value = "5";
			dataGridView2.Rows[29].Cells[1].Value = "6";
			dataGridView2.Rows[30].Cells[1].Value = "6";
			dataGridView2.Rows[31].Cells[1].Value = "6";
			dataGridView2.Rows[32].Cells[1].Value = "6";
			dataGridView2.Rows[33].Cells[1].Value = "-";
			dataGridView2.Rows[34].Cells[1].Value = "-";
			dataGridView2.Rows[35].Cells[1].Value = "-";
			dataGridView2.Rows[36].Cells[1].Value = "-";
			dataGridView2.Rows[37].Cells[1].Value = "-";
			dataGridView2.Rows[38].Cells[1].Value = "-";
			dataGridView2.Rows[39].Cells[1].Value = "-";
			dataGridView2.Rows[40].Cells[1].Value = "-";
			dataGridView2.Rows[41].Cells[1].Value = "-";
			// столбец 2
			dataGridView2.Rows[0].Cells[2].Value = "Тип технической ткани";
			dataGridView2.Rows[1].Cells[2].Value = "Б-800, Б-820";
			dataGridView2.Rows[2].Cells[2].Value = "Б-800, Б-820";
			dataGridView2.Rows[3].Cells[2].Value = "БКНЛ-65, БКНЛ-65-2";
			dataGridView2.Rows[4].Cells[2].Value = "БКНЛ-65, БКНЛ-65-2";
			dataGridView2.Rows[5].Cells[2].Value = "Б-800, Б-820";
			dataGridView2.Rows[6].Cells[2].Value = "Б-800, Б-820";
			dataGridView2.Rows[7].Cells[2].Value = "БКНЛ-65, БКНЛ-65-2";
			dataGridView2.Rows[8].Cells[2].Value = "БКНЛ-65, БКНЛ-65-2";
			dataGridView2.Rows[9].Cells[2].Value = "Б-800, Б-820";
			dataGridView2.Rows[10].Cells[2].Value = "Б-800, Б-820";
			dataGridView2.Rows[11].Cells[2].Value = "БКНЛ-65, БКНЛ-65-2";
			dataGridView2.Rows[12].Cells[2].Value = "БКНЛ-65, БКНЛ-65-2";
			dataGridView2.Rows[13].Cells[2].Value = "Б-800, Б-820";
			dataGridView2.Rows[14].Cells[2].Value = "Б-800, Б-820";
			dataGridView2.Rows[15].Cells[2].Value = "БКНЛ-65, БКНЛ-65-2";
			dataGridView2.Rows[16].Cells[2].Value = "БКНЛ-65, БКНЛ-65-2";
			dataGridView2.Rows[17].Cells[2].Value = "Б-800, Б-820";
			dataGridView2.Rows[18].Cells[2].Value = "Б-800, Б-820";
			dataGridView2.Rows[19].Cells[2].Value = "БКНЛ-65, БКНЛ-65-2";
			dataGridView2.Rows[20].Cells[2].Value = "БКНЛ-65, БКНЛ-65-2";
			dataGridView2.Rows[21].Cells[2].Value = "Б-800, Б-820";
			dataGridView2.Rows[22].Cells[2].Value = "Б-800, Б-820";
			dataGridView2.Rows[23].Cells[2].Value = "БКНЛ-65, БКНЛ-65-2";
			dataGridView2.Rows[24].Cells[2].Value = "БКНЛ-65, БКНЛ-65-2";
			dataGridView2.Rows[25].Cells[2].Value = "Б-800, Б-820";
			dataGridView2.Rows[26].Cells[2].Value = "Б-800, Б-820";
			dataGridView2.Rows[27].Cells[2].Value = "БКНЛ-65, БКНЛ-65-2";
			dataGridView2.Rows[28].Cells[2].Value = "БКНЛ-65, БКНЛ-65-2";
			dataGridView2.Rows[29].Cells[2].Value = "Б-800, Б-820";
			dataGridView2.Rows[30].Cells[2].Value = "Б-800, Б-820";
			dataGridView2.Rows[31].Cells[2].Value = "БКНЛ-65, БКНЛ-65-2";
			dataGridView2.Rows[32].Cells[2].Value = "БКНЛ-65, БКНЛ-65-2";
			dataGridView2.Rows[33].Cells[2].Value = "-";
			dataGridView2.Rows[34].Cells[2].Value = "-";
			dataGridView2.Rows[35].Cells[2].Value = "-";
			dataGridView2.Rows[36].Cells[2].Value = "-";
			dataGridView2.Rows[37].Cells[2].Value = "-";
			dataGridView2.Rows[38].Cells[2].Value = "-";
			dataGridView2.Rows[39].Cells[2].Value = "-";
			dataGridView2.Rows[40].Cells[2].Value = "-";
			dataGridView2.Rows[41].Cells[2].Value = "-";
			// столбец 3
			dataGridView2.Rows[0].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[1].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[2].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[3].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[4].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[5].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[6].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[7].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[8].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[9].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[10].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[11].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[12].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[13].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[14].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[15].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[16].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[17].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[18].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[19].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[20].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[21].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[22].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[23].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[24].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[25].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[26].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[27].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[28].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[29].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[30].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[31].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[32].Cells[3].Value = "Табл.4";
			dataGridView2.Rows[33].Cells[3].Value = "0.4";
			dataGridView2.Rows[34].Cells[3].Value = "0.5";
			dataGridView2.Rows[35].Cells[3].Value = "0.6";
			dataGridView2.Rows[36].Cells[3].Value = "0.7";
			dataGridView2.Rows[37].Cells[3].Value = "0.8";
			dataGridView2.Rows[38].Cells[3].Value = "0.9";
			dataGridView2.Rows[39].Cells[3].Value = "1.0";
			dataGridView2.Rows[40].Cells[3].Value = "1.1";
			dataGridView2.Rows[41].Cells[3].Value = "1.2";
			// столбец 4
			dataGridView2.Rows[0].Cells[4].Value = "Наличие прослоек";
			dataGridView2.Rows[1].Cells[4].Value = "С прослойками";
			dataGridView2.Rows[2].Cells[4].Value = "Без прослоек";
			dataGridView2.Rows[3].Cells[4].Value = "С прослойками";
			dataGridView2.Rows[4].Cells[4].Value = "Без прослоек";
			dataGridView2.Rows[5].Cells[4].Value = "С прослойками";
			dataGridView2.Rows[6].Cells[4].Value = "Без прослоек";
			dataGridView2.Rows[7].Cells[4].Value = "С прослойками";
			dataGridView2.Rows[8].Cells[4].Value = "Без прослоек";
			dataGridView2.Rows[9].Cells[4].Value = "С прослойками";
			dataGridView2.Rows[10].Cells[4].Value = "Без прослоек";
			dataGridView2.Rows[11].Cells[4].Value = "С прослойками";
			dataGridView2.Rows[12].Cells[4].Value = "Без прослоек";
			dataGridView2.Rows[13].Cells[4].Value = "С прослойками";
			dataGridView2.Rows[14].Cells[4].Value = "Без прослоек";
			dataGridView2.Rows[15].Cells[4].Value = "С прослойками";
			dataGridView2.Rows[16].Cells[4].Value = "Без прослоек";
			dataGridView2.Rows[17].Cells[4].Value = "С прослойками";
			dataGridView2.Rows[18].Cells[4].Value = "Без прослоек";
			dataGridView2.Rows[19].Cells[4].Value = "С прослойками";
			dataGridView2.Rows[20].Cells[4].Value = "Без прослоек";
			dataGridView2.Rows[21].Cells[4].Value = "С прослойками";
			dataGridView2.Rows[22].Cells[4].Value = "Без прослоек";
			dataGridView2.Rows[23].Cells[4].Value = "С прослойками";
			dataGridView2.Rows[24].Cells[4].Value = "Без прослоек";
			dataGridView2.Rows[25].Cells[4].Value = "С прослойками";
			dataGridView2.Rows[26].Cells[4].Value = "Без прослоек";
			dataGridView2.Rows[27].Cells[4].Value = "С прослойками";
			dataGridView2.Rows[28].Cells[4].Value = "Без прослоек";
			dataGridView2.Rows[29].Cells[4].Value = "С прослойками";
			dataGridView2.Rows[30].Cells[4].Value = "Без прослоек";
			dataGridView2.Rows[31].Cells[4].Value = "С прослойками";
			dataGridView2.Rows[32].Cells[4].Value = "Без прослоек";
			dataGridView2.Rows[33].Cells[4].Value = "-";
			dataGridView2.Rows[34].Cells[4].Value = "-";
			dataGridView2.Rows[35].Cells[4].Value = "-";
			dataGridView2.Rows[36].Cells[4].Value = "-";
			dataGridView2.Rows[37].Cells[4].Value = "-";
			dataGridView2.Rows[38].Cells[4].Value = "-";
			dataGridView2.Rows[39].Cells[4].Value = "-";
			dataGridView2.Rows[40].Cells[4].Value = "-";
			dataGridView2.Rows[41].Cells[4].Value = "-";
			// столбец 5
			dataGridView2.Rows[0].Cells[5].Value = "Рекомендуемый/допускаемый";
			dataGridView2.Rows[1].Cells[5].Value = "рекомендуемый";
			dataGridView2.Rows[2].Cells[5].Value = "рекомендуемый";
			dataGridView2.Rows[3].Cells[5].Value = "рекомендуемый";
			dataGridView2.Rows[4].Cells[5].Value = "рекомендуемый";
			dataGridView2.Rows[5].Cells[5].Value = "рекомендуемый";
			dataGridView2.Rows[6].Cells[5].Value = "рекомендуемый";
			dataGridView2.Rows[7].Cells[5].Value = "рекомендуемый";
			dataGridView2.Rows[8].Cells[5].Value = "рекомендуемый";
			dataGridView2.Rows[9].Cells[5].Value = "рекомендуемый";
			dataGridView2.Rows[10].Cells[5].Value = "рекомендуемый";
			dataGridView2.Rows[11].Cells[5].Value = "рекомендуемый";
			dataGridView2.Rows[12].Cells[5].Value = "рекомендуемый";
			dataGridView2.Rows[13].Cells[5].Value = "рекомендуемый";
			dataGridView2.Rows[14].Cells[5].Value = "рекомендуемый";
			dataGridView2.Rows[15].Cells[5].Value = "рекомендуемый";
			dataGridView2.Rows[16].Cells[5].Value = "рекомендуемый";
			dataGridView2.Rows[17].Cells[5].Value = "допускаемый";
			dataGridView2.Rows[18].Cells[5].Value = "допускаемый";
			dataGridView2.Rows[19].Cells[5].Value = "допускаемый";
			dataGridView2.Rows[20].Cells[5].Value = "допускаемый";
			dataGridView2.Rows[21].Cells[5].Value = "допускаемый";
			dataGridView2.Rows[22].Cells[5].Value = "допускаемый";
			dataGridView2.Rows[23].Cells[5].Value = "допускаемый";
			dataGridView2.Rows[24].Cells[5].Value = "допускаемый";
			dataGridView2.Rows[25].Cells[5].Value = "допускаемый";
			dataGridView2.Rows[26].Cells[5].Value = "допускаемый";
			dataGridView2.Rows[27].Cells[5].Value = "допускаемый";
			dataGridView2.Rows[28].Cells[5].Value = "допускаемый";
			dataGridView2.Rows[29].Cells[5].Value = "допускаемый";
			dataGridView2.Rows[30].Cells[5].Value = "допускаемый";
			dataGridView2.Rows[31].Cells[5].Value = "допускаемый";
			dataGridView2.Rows[32].Cells[5].Value = "допускаемый";
			dataGridView2.Rows[33].Cells[5].Value = "-";
			dataGridView2.Rows[34].Cells[5].Value = "-";
			dataGridView2.Rows[35].Cells[5].Value = "-";
			dataGridView2.Rows[36].Cells[5].Value = "-";
			dataGridView2.Rows[37].Cells[5].Value = "-";
			dataGridView2.Rows[38].Cells[5].Value = "-";
			dataGridView2.Rows[39].Cells[5].Value = "-";
			dataGridView2.Rows[40].Cells[5].Value = "-";
			dataGridView2.Rows[41].Cells[5].Value = "-";
			// столбец 6
			dataGridView2.Rows[0].Cells[6].Value = "Значение D1";
			dataGridView2.Rows[1].Cells[6].Value = "180";
			dataGridView2.Rows[2].Cells[6].Value = "140";
			dataGridView2.Rows[3].Cells[6].Value = "140";
			dataGridView2.Rows[4].Cells[6].Value = "125";
			dataGridView2.Rows[5].Cells[6].Value = "224";
			dataGridView2.Rows[6].Cells[6].Value = "200";
			dataGridView2.Rows[7].Cells[6].Value = "180";
			dataGridView2.Rows[8].Cells[6].Value = "160";
			dataGridView2.Rows[9].Cells[6].Value = "315";
			dataGridView2.Rows[10].Cells[6].Value = "250";
			dataGridView2.Rows[11].Cells[6].Value = "224";
			dataGridView2.Rows[12].Cells[6].Value = "200";
			dataGridView2.Rows[13].Cells[6].Value = "355";
			dataGridView2.Rows[14].Cells[6].Value = "315";
			dataGridView2.Rows[15].Cells[6].Value = "280";
			dataGridView2.Rows[16].Cells[6].Value = "224";
			dataGridView2.Rows[17].Cells[6].Value = "140";
			dataGridView2.Rows[18].Cells[6].Value = "112";
			dataGridView2.Rows[19].Cells[6].Value = "112";
			dataGridView2.Rows[20].Cells[6].Value = "90";
			dataGridView2.Rows[21].Cells[6].Value = "180";
			dataGridView2.Rows[22].Cells[6].Value = "140";
			dataGridView2.Rows[23].Cells[6].Value = "140";
			dataGridView2.Rows[24].Cells[6].Value = "112";
			dataGridView2.Rows[25].Cells[6].Value = "224";
			dataGridView2.Rows[26].Cells[6].Value = "180";
			dataGridView2.Rows[27].Cells[6].Value = "180";
			dataGridView2.Rows[28].Cells[6].Value = "140";
			dataGridView2.Rows[29].Cells[6].Value = "315";
			dataGridView2.Rows[30].Cells[6].Value = "224";
			dataGridView2.Rows[31].Cells[6].Value = "200";
			dataGridView2.Rows[32].Cells[6].Value = "180";
			dataGridView2.Rows[24].Cells[6].Value = "28";
			dataGridView2.Rows[25].Cells[6].Value = "36";
			dataGridView2.Rows[26].Cells[6].Value = "45";
			dataGridView2.Rows[27].Cells[6].Value = "56";
			dataGridView2.Rows[28].Cells[6].Value = "63";
			dataGridView2.Rows[29].Cells[6].Value = "71";
			dataGridView2.Rows[30].Cells[6].Value = "80";
			dataGridView2.Rows[31].Cells[6].Value = "90";
			dataGridView2.Rows[32].Cells[6].Value = "100";

			#endregion
			#region таблица №3


			dataGridView3.RowCount = 11;
			dataGridView3.ColumnCount = 5;
			//столбец 0 
			dataGridView3.Rows[0].Cells[0].Value = "Материал и вид фрикционного покрытия ремня";
			dataGridView3.Rows[1].Cells[0].Value = "Капроновая ткань просвечивающего или полотняного переплетения, покрытая плёнкой из полиамида в соединении с нитрильным каучуком СКН-40";
			dataGridView3.Rows[2].Cells[0].Value = "Капроновая ткань просвечивающего или полотняного переплетения, покрытая плёнкой из полиамида в соединении с нитрильным каучуком СКН-40";
			dataGridView3.Rows[3].Cells[0].Value = "Капроновая ткань просвечивающего или полотняного переплетения, покрытая плёнкой из полиамида в соединении с нитрильным каучуком СКН-40";
			dataGridView3.Rows[4].Cells[0].Value = "Капроновая ткань просвечивающего или полотняного переплетения, покрытая плёнкой из полиамида в соединении с нитрильным каучуком СКН-40";
			dataGridView3.Rows[5].Cells[0].Value = "Капроновая ткань просвечивающего или полотняного переплетения, покрытая плёнкой из полиамида в соединении с нитрильным каучуком СКН-40";
			dataGridView3.Rows[6].Cells[0].Value = "Капроновая ткань на основе двухуточной саржи, покрытая наиритовым латексом";
			dataGridView3.Rows[7].Cells[0].Value = "Капроновая ткань на основе двухуточной саржи, покрытая наиритовым латексом";
			dataGridView3.Rows[8].Cells[0].Value = "Капроновая ткань на основе двухуточной саржи, покрытая наиритовым латексом";
			dataGridView3.Rows[9].Cells[0].Value = "Капроновая ткань на основе двухуточной саржи, покрытая наиритовым латексом";
			dataGridView3.Rows[10].Cells[0].Value = "Капроновая ткань на основе двухуточной саржи, покрытая наиритовым латексом";
			//столбец 1
			dataGridView3.Rows[0].Cells[1].Value = "Толщина";
			dataGridView3.Rows[1].Cells[1].Value = "0,4…0,6";
			dataGridView3.Rows[2].Cells[1].Value = "0,4…0,6";
			dataGridView3.Rows[3].Cells[1].Value = "0,4…0,6";
			dataGridView3.Rows[4].Cells[1].Value = "0,4…0,6";
			dataGridView3.Rows[5].Cells[1].Value = "0,4…0,6";
			dataGridView3.Rows[6].Cells[1].Value = "1,0…1,2";
			dataGridView3.Rows[7].Cells[1].Value = "1,0…1,2";
			dataGridView3.Rows[8].Cells[1].Value = "1,0…1,2";
			dataGridView3.Rows[9].Cells[1].Value = "1,0…1,2";
			dataGridView3.Rows[10].Cells[1].Value = "1,0…1,2";
			//столбец 2
			dataGridView3.Rows[0].Cells[2].Value = "Ширина";
			dataGridView3.Rows[1].Cells[2].Value = "10";
			dataGridView3.Rows[2].Cells[2].Value = "15";
			dataGridView3.Rows[3].Cells[2].Value = "20";
			dataGridView3.Rows[4].Cells[2].Value = "25";
			dataGridView3.Rows[5].Cells[2].Value = "30";
			dataGridView3.Rows[6].Cells[2].Value = "40";
			dataGridView3.Rows[7].Cells[2].Value = "50";
			dataGridView3.Rows[8].Cells[2].Value = "60";
			dataGridView3.Rows[9].Cells[2].Value = "80";
			dataGridView3.Rows[10].Cells[2].Value = "100";
			//стобец 3
			dataGridView3.Rows[0].Cells[3].Value = "Номинальная L";
			dataGridView3.Rows[1].Cells[3].Value = "250; 260; 280; 300; 320; 340";
			dataGridView3.Rows[2].Cells[3].Value = "350; 380; 400; 420; 450; 480";
			dataGridView3.Rows[3].Cells[3].Value = "500; 530; 560; 600; 630; 670";
			dataGridView3.Rows[4].Cells[3].Value = "710; 750; 800; 850; 900; 950";
			dataGridView3.Rows[5].Cells[3].Value = "1000; 1060; 1120; 1180; 1250; 1320; 1400";
			dataGridView3.Rows[6].Cells[3].Value = "1500; 1600; 1700; 1800; 1900; 2000";
			dataGridView3.Rows[7].Cells[3].Value = "2120; 2240; 2360; 2500; 2650; 2800; 3000; 3150; 3350";
			dataGridView3.Rows[8].Cells[3].Value = "2120; 2240; 2360; 2500; 2650; 2800; 3000; 3150; 3350";
			dataGridView3.Rows[9].Cells[3].Value = "3550; 3750; 4000";
			dataGridView3.Rows[10].Cells[3].Value = "3550; 3750; 4000";
			//столбец 4
			dataGridView3.Rows[0].Cells[4].Value = "Предельное отклонение";
			dataGridView3.Rows[1].Cells[4].Value = "-";
			dataGridView3.Rows[2].Cells[4].Value = "+-20";
			dataGridView3.Rows[3].Cells[4].Value = "-";
			dataGridView3.Rows[4].Cells[4].Value = "-";
			dataGridView3.Rows[5].Cells[4].Value = "+-25";
			dataGridView3.Rows[6].Cells[4].Value = "+-40";
			dataGridView3.Rows[7].Cells[4].Value = "+-45";
			dataGridView3.Rows[8].Cells[4].Value = "+-45";
			dataGridView3.Rows[9].Cells[4].Value = "+-55";
			dataGridView3.Rows[10].Cells[4].Value = "+-55";
			#endregion
			#region таблица №4
			dataGridView4.RowCount = 17;
			dataGridView4.ColumnCount = 5;
			//столбец 0 
			dataGridView4.Rows[0].Cells[0].Value = "Число прокладок";
			dataGridView4.Rows[1].Cells[0].Value = "3";
			dataGridView4.Rows[2].Cells[0].Value = "3";
			dataGridView4.Rows[3].Cells[0].Value = "3";
			dataGridView4.Rows[4].Cells[0].Value = "3";
			dataGridView4.Rows[5].Cells[0].Value = "4";
			dataGridView4.Rows[6].Cells[0].Value = "4";
			dataGridView4.Rows[7].Cells[0].Value = "4";
			dataGridView4.Rows[8].Cells[0].Value = "4";
			dataGridView4.Rows[9].Cells[0].Value = "5";
			dataGridView4.Rows[10].Cells[0].Value = "5";
			dataGridView4.Rows[11].Cells[0].Value = "5";
			dataGridView4.Rows[12].Cells[0].Value = "5";
			dataGridView4.Rows[13].Cells[0].Value = "6";
			dataGridView4.Rows[14].Cells[0].Value = "6";
			dataGridView4.Rows[15].Cells[0].Value = "6";
			dataGridView4.Rows[16].Cells[0].Value = "6";
			//столбец 1
			dataGridView4.Rows[0].Cells[1].Value = "Ширина ремня b, мм";
			dataGridView4.Rows[1].Cells[1].Value = "20…112";
			dataGridView4.Rows[2].Cells[1].Value = "20…112";
			dataGridView4.Rows[3].Cells[1].Value = "20…112";
			dataGridView4.Rows[4].Cells[1].Value = "20…112";
			dataGridView4.Rows[5].Cells[1].Value = "20…250";
			dataGridView4.Rows[6].Cells[1].Value = "20…250";
			dataGridView4.Rows[7].Cells[1].Value = "20…250";
			dataGridView4.Rows[8].Cells[1].Value = "20…250";
			dataGridView4.Rows[9].Cells[1].Value = "20…250";
			dataGridView4.Rows[10].Cells[1].Value = "20…250";
			dataGridView4.Rows[11].Cells[1].Value = "20…250";
			dataGridView4.Rows[12].Cells[1].Value = "20…250";
			dataGridView4.Rows[13].Cells[1].Value = "80…250";
			dataGridView4.Rows[14].Cells[1].Value = "80…250";
			dataGridView4.Rows[15].Cells[1].Value = "80…250";
			dataGridView4.Rows[16].Cells[1].Value = "80…250";
			//столбец 2
			dataGridView4.Rows[0].Cells[2].Value = "Тип технической ткани";
			dataGridView4.Rows[1].Cells[2].Value = "Б-800 и Б-820";
			dataGridView4.Rows[2].Cells[2].Value = "Б-800 и Б-820";
			dataGridView4.Rows[3].Cells[2].Value = "БКНЛ-65 и БКНЛ-65-2";
			dataGridView4.Rows[4].Cells[2].Value = "БКНЛ-65 и БКНЛ-65-2";
			dataGridView4.Rows[5].Cells[2].Value = "Б-800 и Б-820";
			dataGridView4.Rows[6].Cells[2].Value = "Б-800 и Б-820";
			dataGridView4.Rows[7].Cells[2].Value = "БКНЛ-65 и БКНЛ-65-2";
			dataGridView4.Rows[8].Cells[2].Value = "БКНЛ-65 и БКНЛ-65-2";
			dataGridView4.Rows[9].Cells[2].Value = "Б-800 и Б-820";
			dataGridView4.Rows[10].Cells[2].Value = "Б-800 и Б-820";
			dataGridView4.Rows[11].Cells[2].Value = "БКНЛ-65 и БКНЛ-65-2";
			dataGridView4.Rows[12].Cells[2].Value = "БКНЛ-65 и БКНЛ-65-2";
			dataGridView4.Rows[13].Cells[2].Value = "Б-800 и Б-820";
			dataGridView4.Rows[14].Cells[2].Value = "Б-800 и Б-820";
			dataGridView4.Rows[15].Cells[2].Value = "БКНЛ-65 и БКНЛ-65-2";
			dataGridView4.Rows[16].Cells[2].Value = "БКНЛ-65 и БКНЛ-65-2";
			//столбец 3
			dataGridView4.Rows[0].Cells[3].Value = "Наличие прослоек";
			dataGridView4.Rows[1].Cells[3].Value = "С прослойками";
			dataGridView4.Rows[2].Cells[3].Value = "Без прослоек";
			dataGridView4.Rows[3].Cells[3].Value = "С прослойками";
			dataGridView4.Rows[4].Cells[3].Value = "Без прослоек";
			dataGridView4.Rows[5].Cells[3].Value = "С прослойками";
			dataGridView4.Rows[6].Cells[3].Value = "Без прослоек";
			dataGridView4.Rows[7].Cells[3].Value = "С прослойками";
			dataGridView4.Rows[8].Cells[3].Value = "Без прослоек";
			dataGridView4.Rows[9].Cells[3].Value = "С прослойками";
			dataGridView4.Rows[10].Cells[3].Value = "Без прослоек";
			dataGridView4.Rows[11].Cells[3].Value = "С прослойками";
			dataGridView4.Rows[12].Cells[3].Value = "Без прослоек";
			dataGridView4.Rows[13].Cells[3].Value = "С прослойками";
			dataGridView4.Rows[14].Cells[3].Value = "Без прослоек";
			dataGridView4.Rows[15].Cells[3].Value = "С прослойками";
			dataGridView4.Rows[16].Cells[3].Value = "Без прослоек";
			//столбец 4
			dataGridView4.Rows[0].Cells[4].Value = "Толщина";
			dataGridView4.Rows[1].Cells[4].Value = "4,5";
			dataGridView4.Rows[2].Cells[4].Value = "3,75";
			dataGridView4.Rows[3].Cells[4].Value = "3,6";
			dataGridView4.Rows[4].Cells[4].Value = "3,0";
			dataGridView4.Rows[5].Cells[4].Value = "6,0";
			dataGridView4.Rows[6].Cells[4].Value = "5,0";
			dataGridView4.Rows[7].Cells[4].Value = "4,8";
			dataGridView4.Rows[8].Cells[4].Value = "4,0";
			dataGridView4.Rows[9].Cells[4].Value = "7,5";
			dataGridView4.Rows[10].Cells[4].Value = "6,25";
			dataGridView4.Rows[11].Cells[4].Value = "6,0";
			dataGridView4.Rows[12].Cells[4].Value = "5,0";
			dataGridView4.Rows[13].Cells[4].Value = "9,0";
			dataGridView4.Rows[14].Cells[4].Value = "7,5";
			dataGridView4.Rows[15].Cells[4].Value = "7,2";
			dataGridView4.Rows[16].Cells[4].Value = "6,0";


			#endregion
			#region таблица №5
			dataGridView5.RowCount = 46;
			dataGridView5.ColumnCount = 4;
			//столбец 0 
			dataGridView5.Rows[0].Cells[0].Value = "Название параметра шкива:";
			dataGridView5.Rows[1].Cells[0].Value = "Диаметр шкива, мм";
			dataGridView5.Rows[2].Cells[0].Value = "Диаметр шкива, мм";
			dataGridView5.Rows[3].Cells[0].Value = "Диаметр шкива, мм";
			dataGridView5.Rows[4].Cells[0].Value = "Диаметр шкива, мм";
			dataGridView5.Rows[5].Cells[0].Value = "Диаметр шкива, мм";
			dataGridView5.Rows[6].Cells[0].Value = "Диаметр шкива, мм";
			dataGridView5.Rows[7].Cells[0].Value = "Диаметр шкива, мм";
			dataGridView5.Rows[8].Cells[0].Value = "Диаметр шкива, мм";
			dataGridView5.Rows[9].Cells[0].Value = "Диаметр шкива, мм";
			dataGridView5.Rows[10].Cells[0].Value = "Диаметр шкива, мм";
			dataGridView5.Rows[11].Cells[0].Value = "Диаметр шкива, мм";
			dataGridView5.Rows[12].Cells[0].Value = "Диаметр шкива, мм";
			dataGridView5.Rows[13].Cells[0].Value = "Диаметр шкива, мм";
			dataGridView5.Rows[14].Cells[0].Value = "Диаметр шкива, мм";
			dataGridView5.Rows[15].Cells[0].Value = "Диаметр шкива, мм";
			dataGridView5.Rows[16].Cells[0].Value = "Ширина шкива B<=D, мм…";
			dataGridView5.Rows[17].Cells[0].Value = "Ширина шкива B<=D, мм…";
			dataGridView5.Rows[18].Cells[0].Value = "Ширина шкива B<=D, мм…";
			dataGridView5.Rows[19].Cells[0].Value = "Ширина шкива B<=D, мм…";
			dataGridView5.Rows[20].Cells[0].Value = "Ширина шкива B<=D, мм…";
			dataGridView5.Rows[21].Cells[0].Value = "Ширина шкива B<=D, мм…";
			dataGridView5.Rows[22].Cells[0].Value = "Ширина шкива B<=D, мм…";
			dataGridView5.Rows[23].Cells[0].Value = "Ширина шкива B<=D, мм…";
			dataGridView5.Rows[24].Cells[0].Value = "Ширина шкива B<=D, мм…";
			dataGridView5.Rows[25].Cells[0].Value = "Ширина шкива B<=D, мм…";
			dataGridView5.Rows[26].Cells[0].Value = "Ширина шкива B<=D, мм…";
			dataGridView5.Rows[27].Cells[0].Value = "Ширина шкива B<=D, мм…";
			dataGridView5.Rows[28].Cells[0].Value = "Ширина шкива B<=D, мм…";
			dataGridView5.Rows[29].Cells[0].Value = "Ширина шкива B<=D, мм…";
			dataGridView5.Rows[30].Cells[0].Value = "Ширина шкива B<=D, мм…";
			dataGridView5.Rows[31].Cells[0].Value = "Рекомендуемая ширина ремня, b";
			dataGridView5.Rows[32].Cells[0].Value = "Рекомендуемая ширина ремня, b";
			dataGridView5.Rows[33].Cells[0].Value = "Рекомендуемая ширина ремня, b";
			dataGridView5.Rows[34].Cells[0].Value = "Рекомендуемая ширина ремня, b";
			dataGridView5.Rows[35].Cells[0].Value = "Рекомендуемая ширина ремня, b";
			dataGridView5.Rows[36].Cells[0].Value = "Рекомендуемая ширина ремня, b";
			dataGridView5.Rows[37].Cells[0].Value = "Рекомендуемая ширина ремня, b";
			dataGridView5.Rows[38].Cells[0].Value = "Рекомендуемая ширина ремня, b";
			dataGridView5.Rows[39].Cells[0].Value = "Рекомендуемая ширина ремня, b";
			dataGridView5.Rows[40].Cells[0].Value = "Рекомендуемая ширина ремня, b";
			dataGridView5.Rows[41].Cells[0].Value = "Рекомендуемая ширина ремня, b";
			dataGridView5.Rows[42].Cells[0].Value = "Рекомендуемая ширина ремня, b";
			dataGridView5.Rows[43].Cells[0].Value = "Рекомендуемая ширина ремня, b";
			dataGridView5.Rows[44].Cells[0].Value = "Рекомендуемая ширина ремня, b";
			dataGridView5.Rows[45].Cells[0].Value = "Рекомендуемая ширина ремня, b";
			//столбцец 1
			dataGridView5.Rows[0].Cells[1].Value = "Значение параметра шкива:";
			dataGridView5.Rows[1].Cells[1].Value = "63";
			dataGridView5.Rows[2].Cells[1].Value = "71";
			dataGridView5.Rows[3].Cells[1].Value = "80";
			dataGridView5.Rows[4].Cells[1].Value = "90";
			dataGridView5.Rows[5].Cells[1].Value = "100";
			dataGridView5.Rows[6].Cells[1].Value = "112";
			dataGridView5.Rows[7].Cells[1].Value = "125";
			dataGridView5.Rows[8].Cells[1].Value = "140";
			dataGridView5.Rows[9].Cells[1].Value = "160";
			dataGridView5.Rows[10].Cells[1].Value = "180";
			dataGridView5.Rows[11].Cells[1].Value = "200";
			dataGridView5.Rows[12].Cells[1].Value = "224";
			dataGridView5.Rows[13].Cells[1].Value = "250";
			dataGridView5.Rows[14].Cells[1].Value = "280";
			dataGridView5.Rows[15].Cells[1].Value = "315";
			dataGridView5.Rows[16].Cells[1].Value = "25";
			dataGridView5.Rows[17].Cells[1].Value = "32";
			dataGridView5.Rows[18].Cells[1].Value = "40";
			dataGridView5.Rows[19].Cells[1].Value = "50";
			dataGridView5.Rows[20].Cells[1].Value = "63";
			dataGridView5.Rows[21].Cells[1].Value = "71";
			dataGridView5.Rows[22].Cells[1].Value = "80";
			dataGridView5.Rows[23].Cells[1].Value = "90";
			dataGridView5.Rows[24].Cells[1].Value = "100";
			dataGridView5.Rows[25].Cells[1].Value = "112";
			dataGridView5.Rows[26].Cells[1].Value = "125";
			dataGridView5.Rows[27].Cells[1].Value = "140";
			dataGridView5.Rows[28].Cells[1].Value = "160";
			dataGridView5.Rows[29].Cells[1].Value = "180";
			dataGridView5.Rows[30].Cells[1].Value = "200";
			dataGridView5.Rows[31].Cells[1].Value = "20";
			dataGridView5.Rows[32].Cells[1].Value = "25";
			dataGridView5.Rows[33].Cells[1].Value = "32";
			dataGridView5.Rows[34].Cells[1].Value = "40";
			dataGridView5.Rows[35].Cells[1].Value = "50";
			dataGridView5.Rows[36].Cells[1].Value = "63";
			dataGridView5.Rows[37].Cells[1].Value = "71";
			dataGridView5.Rows[38].Cells[1].Value = "80";
			dataGridView5.Rows[39].Cells[1].Value = "90";
			dataGridView5.Rows[40].Cells[1].Value = "100";
			dataGridView5.Rows[41].Cells[1].Value = "112";
			dataGridView5.Rows[42].Cells[1].Value = "125";
			dataGridView5.Rows[43].Cells[1].Value = "140";
			dataGridView5.Rows[44].Cells[1].Value = "160";
			dataGridView5.Rows[45].Cells[1].Value = "180";
			//столбцец 2
			dataGridView5.Rows[0].Cells[2].Value = "Предельное отклонение, мм";
			dataGridView5.Rows[1].Cells[2].Value = "+-0,8";
			dataGridView5.Rows[2].Cells[2].Value = "+-1";
			dataGridView5.Rows[3].Cells[2].Value = "+-1";
			dataGridView5.Rows[4].Cells[2].Value = "+-1,2";
			dataGridView5.Rows[5].Cells[2].Value = "+-1,2";
			dataGridView5.Rows[6].Cells[2].Value = "+-1,2";
			dataGridView5.Rows[7].Cells[2].Value = "+-1,6";
			dataGridView5.Rows[8].Cells[2].Value = "+-1,6";
			dataGridView5.Rows[9].Cells[2].Value = "+-2";
			dataGridView5.Rows[10].Cells[2].Value = "+-2";
			dataGridView5.Rows[11].Cells[2].Value = "+-2,5";
			dataGridView5.Rows[12].Cells[2].Value = "+-2,5";
			dataGridView5.Rows[13].Cells[2].Value = "+-2,5";
			dataGridView5.Rows[14].Cells[2].Value = "+-3,2";
			dataGridView5.Rows[15].Cells[2].Value = "+-3,2";
			dataGridView5.Rows[16].Cells[2].Value = "+-1";
			dataGridView5.Rows[17].Cells[2].Value = "+-1";
			dataGridView5.Rows[18].Cells[2].Value = "+-1";
			dataGridView5.Rows[19].Cells[2].Value = "+-1";
			dataGridView5.Rows[20].Cells[2].Value = "+-1";
			dataGridView5.Rows[21].Cells[2].Value = "+-1";
			dataGridView5.Rows[22].Cells[2].Value = "+-1,5";
			dataGridView5.Rows[23].Cells[2].Value = "+-1,5";
			dataGridView5.Rows[24].Cells[2].Value = "+-1,5";
			dataGridView5.Rows[25].Cells[2].Value = "+-1,5";
			dataGridView5.Rows[26].Cells[2].Value = "+-1,5";
			dataGridView5.Rows[27].Cells[2].Value = "+-1,5";
			dataGridView5.Rows[28].Cells[2].Value = "+-2";
			dataGridView5.Rows[29].Cells[2].Value = "+-2";
			dataGridView5.Rows[30].Cells[2].Value = "+-2";
			dataGridView5.Rows[31].Cells[2].Value = "-";
			dataGridView5.Rows[32].Cells[2].Value = "-";
			dataGridView5.Rows[33].Cells[2].Value = "-";
			dataGridView5.Rows[34].Cells[2].Value = "-";
			dataGridView5.Rows[35].Cells[2].Value = "-";
			dataGridView5.Rows[36].Cells[2].Value = "-";
			dataGridView5.Rows[37].Cells[2].Value = "-";
			dataGridView5.Rows[38].Cells[2].Value = "-";
			dataGridView5.Rows[39].Cells[2].Value = "-";
			dataGridView5.Rows[40].Cells[2].Value = "-";
			dataGridView5.Rows[41].Cells[2].Value = "-";
			dataGridView5.Rows[42].Cells[2].Value = "-";
			dataGridView5.Rows[43].Cells[2].Value = "-";
			dataGridView5.Rows[44].Cells[2].Value = "-";
			dataGridView5.Rows[45].Cells[2].Value = "-";
			//столбцец 3
			dataGridView5.Rows[0].Cells[3].Value = "Стрела выпуклости h, mm…";
			dataGridView5.Rows[1].Cells[3].Value = "0,3";
			dataGridView5.Rows[2].Cells[3].Value = "0,3";
			dataGridView5.Rows[3].Cells[3].Value = "0,3";
			dataGridView5.Rows[4].Cells[3].Value = "0,3";
			dataGridView5.Rows[5].Cells[3].Value = "0,3";
			dataGridView5.Rows[6].Cells[3].Value = "0,3";
			dataGridView5.Rows[7].Cells[3].Value = "0,4";
			dataGridView5.Rows[8].Cells[3].Value = "0,4";
			dataGridView5.Rows[9].Cells[3].Value = "0,5";
			dataGridView5.Rows[10].Cells[3].Value = "0,5";
			dataGridView5.Rows[11].Cells[3].Value = "-";
			dataGridView5.Rows[12].Cells[3].Value = "0,6";
			dataGridView5.Rows[13].Cells[3].Value = "0,8";
			dataGridView5.Rows[14].Cells[3].Value = "0,8";
			dataGridView5.Rows[15].Cells[3].Value = "1";
			dataGridView5.Rows[16].Cells[3].Value = "-";
			dataGridView5.Rows[17].Cells[3].Value = "-";
			dataGridView5.Rows[18].Cells[3].Value = "-";
			dataGridView5.Rows[19].Cells[3].Value = "-";
			dataGridView5.Rows[20].Cells[3].Value = "-";
			dataGridView5.Rows[21].Cells[3].Value = "-";
			dataGridView5.Rows[22].Cells[3].Value = "-";
			dataGridView5.Rows[23].Cells[3].Value = "-";
			dataGridView5.Rows[24].Cells[3].Value = "-";
			dataGridView5.Rows[25].Cells[3].Value = "-";
			dataGridView5.Rows[26].Cells[3].Value = "-";
			dataGridView5.Rows[27].Cells[3].Value = "-";
			dataGridView5.Rows[28].Cells[3].Value = "-";
			dataGridView5.Rows[29].Cells[3].Value = "-";
			dataGridView5.Rows[30].Cells[3].Value = "-";
			dataGridView5.Rows[31].Cells[3].Value = "-";
			dataGridView5.Rows[32].Cells[3].Value = "-";
			dataGridView5.Rows[33].Cells[3].Value = "-";
			dataGridView5.Rows[34].Cells[3].Value = "-";
			dataGridView5.Rows[35].Cells[3].Value = "-";
			dataGridView5.Rows[36].Cells[3].Value = "-";
			dataGridView5.Rows[37].Cells[3].Value = "-";
			dataGridView5.Rows[38].Cells[3].Value = "-";
			dataGridView5.Rows[39].Cells[3].Value = "-";
			dataGridView5.Rows[40].Cells[3].Value = "-";
			dataGridView5.Rows[41].Cells[3].Value = "-";
			dataGridView5.Rows[42].Cells[3].Value = "-";
			dataGridView5.Rows[43].Cells[3].Value = "-";
			dataGridView5.Rows[44].Cells[3].Value = "-";
			dataGridView5.Rows[45].Cells[3].Value = "-";



			#endregion
		}


















		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
