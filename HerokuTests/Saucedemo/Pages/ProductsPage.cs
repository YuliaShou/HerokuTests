using HerokuTests.Pages;
using HerokuTests.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;

namespace HerokuTests.Saucedemo.Pages
{
    public class ProductsPage:BasePage
    {
        private By ProductPageLocator = By.XPath("//span[text()='Products']");
        private const string AddToCartButtonLocator = "//div[text()='{0}']/ancestor::div[@class='inventory_item']//button[text()='Add to cart']";
        private By CartCountLocator = By.XPath("//span[@class='shopping_cart_badge']");
        private By CartLocator = By.XPath("//a[@class='shopping_cart_link']");

        LabelElement ProductPageLabel  => new LabelElement(ProductPageLocator);
        ButtonElement AddToCartButton(string itemName) => new ButtonElement(By.XPath(Format(AddToCartButtonLocator, itemName)));
        LabelElement CartCountLabel => new LabelElement(CartCountLocator);
        ButtonElement CartButton => new ButtonElement(CartLocator);

        public bool IsProductLabelDisplayed()
        {
            return ProductPageLabel.IsElementDisplayed();
        }

        public void AddItemToCart(string itemName)
        {
            AddToCartButton(itemName).ClickElement();
        }

        public string GetTextFromCartCountLabel()
        {
            return CartCountLabel.GetText();
        }

        public void ClikCartButton()
        {
            CartButton.ClickElement();
        }
    }
}
