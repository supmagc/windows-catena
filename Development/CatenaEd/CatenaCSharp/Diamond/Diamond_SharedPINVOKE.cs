/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Diamond {

class Diamond_SharedPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="SWIGRegisterExceptionCallbacks_Diamond_Shared")]
    public static extern void SWIGRegisterExceptionCallbacks_Diamond_Shared(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_Diamond_Shared")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_Diamond_Shared(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_Diamond_Shared(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_Diamond_Shared(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(Diamond_SharedPINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(Diamond_SharedPINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="SWIGRegisterStringCallback_Diamond_Shared")]
    public static extern void SWIGRegisterStringCallback_Diamond_Shared(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_Diamond_Shared(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static Diamond_SharedPINVOKE() {
  }


  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp__H_DIAMOND_CORE_get")]
  public static extern int _H_DIAMOND_CORE_get();

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_new_Core")]
  public static extern global::System.IntPtr new_Core();

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_delete_Core")]
  public static extern void delete_Core(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_Core_CreateScene")]
  public static extern global::System.IntPtr Core_CreateScene(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_Core_CreateWindowCanvas")]
  public static extern global::System.IntPtr Core_CreateWindowCanvas(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_Core_CreateInteractiveViewer")]
  public static extern global::System.IntPtr Core_CreateInteractiveViewer(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_Core_Update")]
  public static extern bool Core_Update(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_Core_Release__SWIG_0")]
  public static extern void Core_Release__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_Core_Release__SWIG_1")]
  public static extern void Core_Release__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_Core_Release__SWIG_2")]
  public static extern void Core_Release__SWIG_2(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp__H_DIAMOND_SCENE_get")]
  public static extern int _H_DIAMOND_SCENE_get();

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_new_Scene")]
  public static extern global::System.IntPtr new_Scene(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_delete_Scene")]
  public static extern void delete_Scene(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_Scene_GetCore__SWIG_0")]
  public static extern global::System.IntPtr Scene_GetCore__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_Scene_CreateRenderer")]
  public static extern global::System.IntPtr Scene_CreateRenderer(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_Scene_GetRenderers")]
  public static extern global::System.IntPtr Scene_GetRenderers(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_Scene_Update__SWIG_0")]
  public static extern void Scene_Update__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2, bool jarg3);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_Scene_Update__SWIG_1")]
  public static extern void Scene_Update__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_Scene_Release")]
  public static extern void Scene_Release(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp__H_DIAMOND_SCENEVIEW_get")]
  public static extern int _H_DIAMOND_SCENEVIEW_get();

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_delete_SceneView")]
  public static extern void delete_SceneView(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_SceneView_SetSize")]
  public static extern void SceneView_SetSize(global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2, uint jarg3);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_SceneView_SetFullscreen")]
  public static extern void SceneView_SetFullscreen(global::System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_SceneView_GetWidth")]
  public static extern uint SceneView_GetWidth(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_SceneView_GetHeight")]
  public static extern uint SceneView_GetHeight(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("Diamond_Shared", EntryPoint="CSharp_SceneView_GetFullscreen")]
  public static extern bool SceneView_GetFullscreen(global::System.Runtime.InteropServices.HandleRef jarg1);
}

}
