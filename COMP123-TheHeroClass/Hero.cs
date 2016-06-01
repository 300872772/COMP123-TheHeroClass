using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_TheHeroClass
{

    /**
     * <summary>
     * This 'Hero' class defines a charecter Hero which has 4 fields, 1 properties, 3 private methods and 2 public methods 
     * 
     * @class Hero
     * @field {int} _strength
     * @field {int} _speed
     * @field {int} _health
     * @field {string} _name
     * </summary>
     * 
     */
    class Hero
    {

        //PRIVATE INSTANCE VARIABLE+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private int _strength;
        private int _speed;
        private int _health;
        private string _name;

        //PUBLIC PROPERTIES+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is a property for _name field
        * @property {string} Name 
        * </summary>
        * 
        */

        public string Name
        {

            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /**
        * <summary>
        * This is a property for _strength field
        * @property {int} Strength 
        * </summary>
        * 
        */

        public int Strength
        {

            get
            {
                return this._strength;
            }
            set
            {
                this._strength = value;
            }
        }
        /**
        * <summary>
        * This is a property for _speed field
        * @property {int} Speed 
        * </summary>
        * 
        */

        public int Speed
        {

            get
            {
                return this._speed;
            }
            set
            {
                this._speed = value;
            }
        }
        
        /**
        * <summary>
        * This is a property for _health field
        * @property {int} Health 
        * </summary>
        * 
        */

        public int Health
        {

            get
            {
                return this._health;
            }
            set
            {
                this._health = value;
            }
        }



        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the constructor that takes the name parametere and passes to nameinstance variable
        *  and call _generateAbilit Method.
        * @param {string} name 
        * 
        * </summary>
        * 
        */

        public Hero(string name)
        {
            _generateAbility();
            this.Name = name;


        }
        //PRIVATE METHODES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This the privte method that generate random nuber and passed to _speed, _strength and _health instance variable
        * 
        * @returns {void}        * 
        * </summary>
        * 
        */

        private void _generateAbility ()
        {
            Random random = new Random();
            this.Speed = random.Next(1, 100);
            this.Strength = random.Next(1, 100);
            this.Health = random.Next(1, 100);
        }
        
         /**
        * <summary>
        * This the privte method that generate 
        * 
        * @param (int) setProb
        * @returns {bool}        * 
        * </summary>
        * 
        */

        private bool _hitAttempt(int setProb)
        {
            Random random = new Random();
            int probability = random.Next(100);

            if(probability<=setProb)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
         /**
        * <summary>
        * This the privte method that generate 
        * 
        * @returns {int}        * 
        * </summary>
        * 
        */
        private int _hitDamage()
        {
            Random random = new Random();
            int damage = (random.Next(1, 6))* this.Strength;

            return damage;
        }

        //PUBLIC METHODS++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * 
        * 
        * </summary>
        * 
        */
        public void Fight()
        {
            if (_hitAttempt(100)==true)
            {
               Console.WriteLine( "Damage value is {0} ",_hitDamage());

            }

        }

        /**
        * <summary>
        * 
        * 
        * </summary>
        * 
        */

        public void Show()
        {
            Console.WriteLine("Name:{0}\n Strength: {1}\n Speed:{2}\n Health:{3}\n",this.Name, this.Strength, this.Speed, this.Health);

        }

    }
}
