using System;

namespace task4_csharp.Models
{
    public class Loader : ILoader
    {
        public event EventHandler OilLoaded;

        public OilRigStatus LoadOil()
        {
            OnOilLoaded();
            return OilRigStatus.LoadingOil;
        }

        protected virtual void OnOilLoaded()
        {
            OilLoaded?.Invoke(this, EventArgs.Empty);
        }
    }
}
