using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_TheHeroClass;

namespace UnitTestProjectForTheHeroClass
{

    /**
     * <summary>
     *This class is used for testing Hero Class
     * 
     * @class  
     * </summary>
     */
    [TestClass]
    public class UnitTestForHeroClass
    {
        /**
        * <summary>
        *This method is used for testing _generateAbility method under Hero class
        * 
        * @method TestMethodFor_generalAbility
        * @return {void}  
        * </summary>
        */

        [TestMethod]
        public void TestMethodFor_generalAbility()
        {

            //Arrange

            //Act

            //Assert

        }

        /**
        * <summary>
        *This method is used for testing _hitDamage method under Hero class
        * 
        * @method TestMethodFor_hitDamage
        * @return {void}
        * </summary>
        */

        [TestMethod]
        public void TestMethodFor_hitDamage()
        {

            //Arrange
            Hero hero = new Hero("Mamun");
            //Act
            int result = hero._hitDamage();

            //Assert
            Assert.IsNotNull(result);
            
        }
        /**
        * <summary>
        *This method is used for testing _hitAttempt method under Hero class
        * 
        * @method TestMethodFor_hitAttempt
        * @return {void}
        * </summary>
        */

        [TestMethod]
        public void TestMethodFor_hitAttempt()
        {
            
            //Arrange
            int probability = 100;
            Hero hero = new Hero("Mamun");
            //Act
            bool result = hero._hitAttempt(probability);

            //Assert
            Assert.IsTrue(result);
            
        }
        /**
        * <summary>
        *This method is used for testing Fight method under Hero class
        * 
        * @method TestMethodForFight
        * @return {void}
        * </summary>
        */

        [TestMethod]
        public void TestMethodForFight()
        {

            //Arrange
            Hero hero = new Hero("Mamun");
            string expectedResult = null;
            //Act
            hero.Fight();

            //Assert
            
            
        }
        /**
        * <summary>
        *This method is used for testing Show method under Hero class
        * 
        * @method TestMethodForShow
        * @return {void}
        * </summary>
        */

        [TestMethod]
        public void TestMethodForShow()
        {

            //Arrange
            Hero hero = new Hero("Mamun");
            string expectedResult = null;
            //Act
            hero.Show();

            //Assert
            
            
        }






    }
}
