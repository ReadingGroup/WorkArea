using BreakOutMethod.Dependency;

namespace BreakOutMethod
{
    public abstract class Dog
    {
        private Water m_water = new Water();
        private Food m_food = new Food();
        private Ball m_ball = new Ball();

        private string diary;

        
        
        //test this method without new Dog class:

        public string NeedTestMethod_DogDay()
        {
            diary = string.Empty;

            diary += WakeUp();
            diary += Eat(m_food);
            diary += Drink(m_water);
            diary += Play(m_ball);
            diary += Sleep();

            return diary;
        }



        private string WakeUp()
        {
            return "WakeUp";
        }

        private string Eat(Food food)
        {
            return "Eat" + food.ToString();
        }

        private string Drink(Water water)
        {
            return "Drink" + water.ToString();
        }

        private string Play(Ball ball)
        {
            return "Play" + ball.ToString();
        }

        private string Sleep()
        {
            return "Sleep";
        }
    }
}
