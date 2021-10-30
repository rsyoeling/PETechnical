﻿namespace Presenters
{
    public class CreateOrderPresenter : IPresenter<int, string>
    {
        public string Content { get; private set; }

        public void Handle(int response)
        {
            //Content = $"Orden ID: {response}";
            Content = "{ 'ID': '"+ response.ToString() + "'}";
        }
    }
}
