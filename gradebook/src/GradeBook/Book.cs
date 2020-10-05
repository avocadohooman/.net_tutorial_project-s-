using System.Collections.Generic;
using System;

namespace GradeBook 
{

		public delegate void GradeAddedDelegate(object sender, EventArgs args);

		public class NamedObject
		{

			public NamedObject(string name)
			{
				Name = name;
			}

			public string Name
			{
				get;
				set;
			}
		}

		public abstract class BookBase : NamedObject
		{	

			public BookBase(string name) : base(name)
			{

			}
			public abstract void AddGrade(double grade);
		}

    	public class Book : BookBase
		{
			private List<double> grades;

			const string CATEGORY = "Science";

			public Book(string name) : base(name)
			{
				if (name.Length == 0) 
				{
					Console.WriteLine("Please choose a name for the book");
				}
				else 
				{
					grades = new List<double>();
					Name = name;
				}
			}

			public void AddLetterGrade(char letter)
			{
				switch(letter)
				{
					case 'A':
						AddGrade(90);
						break;
					case 'B':
						AddGrade(80);
						break;
					case 'C':
						AddGrade(70);
						break;
					case 'D':
						AddGrade(60);
						break;
					case 'F':
						AddGrade(49);
						break;
					default:
						AddGrade(0);
						break;
				}
			}

			public void AddGrade(double grade)
			{
				if (grade <= 100 && grade >= 0)
				{
					this.grades.Add(grade);
					if (GradeAdded != null)
					{
						GradeAdded(this, new EventArgs());
					}
				}
				else 
				{
					throw new ArgumentException($"Invalid {nameof(grade)}");
				}
			}

			public event GradeAddedDelegate GradeAdded;

			public Statistics getStatistics()
			{
				var result = new Statistics();
				result.Average = 0.0;
				result.High = double.MinValue;
				result.Low = double.MaxValue;
				foreach(var grade in grades) 
				{
					if (grade > result.High) {
						result.High = grade;
					}
					if (grade < result.Low) {
						result.Low = grade;
					}
					result.Average += grade;
				}
				result.Average /= grades.Count;
				switch(result.Average)
				{
					case var d when d >= 90.0:
						result.Letter = 'A';
						break;
					case var d when d >= 80.0:
						result.Letter = 'B';
						break;
					case var d when d >= 70.0:
						result.Letter = 'C';
						break;
					case var d when d >= 60.0:
						result.Letter = 'D';
						break;	
					default:
						result.Letter = 'F';
						break;										
				}
				return (result);
			}
		}
}