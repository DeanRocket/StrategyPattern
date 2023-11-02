using StrategyPattern.Exercise.Implement;
using StrategyPattern.Exercise.Interface;
using StrategyPattern.Pay.Implement;
using StrategyPattern.Pay.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Person
{
    public abstract class Person
    {
        Paybehavior paybehavior = new PayByCard();
        ExerciseBehavior exerciseBehavior = new PlayBasketball();
        public abstract void Display();
        public void SetExerciseBehavior(ExerciseBehavior exerciseBehavior) { 
            this.exerciseBehavior = exerciseBehavior;
        }
        public void SetPaybehavior(Paybehavior paybehavior)
        {
            this.paybehavior = paybehavior;
        }
        public void PerformPay()
        {
            paybehavior.Pay();
        }
        public void PerformExercise()
        {
            exerciseBehavior.Exercise();
        }
    }
}
