using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Anisimov_Egor
{
	public class Peredacha
	{

		// счётчик
		public int i;
		//номера передлач
		public int[] Nomer = new int[15];

		// входные данные 
		public string[] abvg = new string[15]; // как будет происходить расчёт D1
		public double[] N = new double[15]; // мощность
		public double[] n1 = new double[15]; // частота вращения меньшего шкива
		public string[] VidRem = new string[15]; // тип ремня
		public string[] VidTKA = new string[15]; // вид технической ткани
		public double[] prok = new double[15]; // число прокладок
		public double[] b = new double[15]; // ширина ремня 
		public string[] prosnal = new string[15]; // наличие прослоек 
		public double[] Del = new double[15];// толщина синтетического ремня
		public double[] n2 = new double[15]; //  частота вращения большего шкива
		public double[] E = new double[15]; //  коэффициент скольжения, E
		public string[] VidPer = new string[15]; // вид передачи
		public string[] SposobL = new string[15]; // способ определения длины ремня 
		public double[] nchastots= new double[15]; //  частота пробега ремня в секундах
		public string[] MatVid = new string[15]; // материал и вид фрикционного покрытия ремня
		public string[] OprShirremCKH_40 = new string[15]; // Определение ширины ремня b CKH-40
		public string[] OprShirremSar = new string[15]; // Определение ширины ремня b ткань на основе двухточной саржи

		//подгоночный коэффициент
		public double[] Kp = new double[15]; // подгоночный коэффициент для саверина
		
		// выводные данные
		public double[] D1a = new double[15];
		public double[] D1b = new double[15];
		public double[] D1v = new double[15];
		public double[] D1g = new double[15];
		public double[] D1 = new double[15]; // меньший диаметр
		public double[] v = new double[15]; // скорость ремня
		public double[] u = new double[15]; // передаточное число
		public double[] D2 = new double[15]; //определение большего шкива
		public double[] amin = new double[15]; // определение минимального межосевого расстояния
		public double[] K = new double[15]; // определение коэффициента для медосевого расстояния
		public double[] L = new double[15]; // определение длины ремня 
		public double[] a = new double[15]; // межосевое расстояние
		public double[] a1 = new double[15]; // угол обхвата на меньшем шкиве


	}
}
