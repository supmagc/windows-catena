/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class Diamond {
  public static SWIGTYPE_p_DLL_IMPORT Core {
    set {
      DiamondPINVOKE.Core_set(SWIGTYPE_p_DLL_IMPORT.getCPtr(value));
      if (DiamondPINVOKE.SWIGPendingException.Pending) throw DiamondPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_DLL_IMPORT ret = new SWIGTYPE_p_DLL_IMPORT(DiamondPINVOKE.Core_get(), true);
      if (DiamondPINVOKE.SWIGPendingException.Pending) throw DiamondPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
