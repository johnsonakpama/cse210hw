using System;

public class Product
{
    private string _productName;
    private int _productID;
    private float _price;
    private int _quanity;

    public Product(string productName, int productID, float price, int quanity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quanity = quanity;
    }

    public int GetProductID()
    {
        _productID = productID;
    }

    public void SetProductID()
    {
        return productID;
    }

    public float GetPrice()
    {
        _price = price;
    }

    public void SetPrice()
    {
        return price;
    }

    public int GetQuanity()
    {
        _quanity = quanity;
    }

    public void SetQuanity()
    {
        return quanity;
    }

    public int CaculatePrice(float price, int quanity)
    {
        return price * quanity;
    }

}