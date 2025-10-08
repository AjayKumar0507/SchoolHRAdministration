using System;
using HRAdministrationAPI;
using System.Linq;

namespace HRAdministrationAPI
{
    public static class FactoryPatter<K,T> where T:class, K, new()
    {
        // The generic constraints mean:

        // T: class — T must be a reference type (a class, interface, delegate, or array).
        // T: K — T must implement or inherit from the type K (K could be an interface or a base class).
        // T: new() — T must have a public parameterless constructor. 
        // This constraint allows the code new T() to create an instance inside the generic method or class.
        
        public static K GetInstance()
        {
            K objK;
            objK = new T();
            return objK;
        }
    }
}