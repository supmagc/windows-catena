/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Diamond {

public class Core : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Core(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Core obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Core() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Diamond_SharedPINVOKE.delete_Core(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Core() : this(Diamond_SharedPINVOKE.new_Core(), true) {
  }

  public Scene CreateScene() {
    global::System.IntPtr cPtr = Diamond_SharedPINVOKE.Core_CreateScene(swigCPtr);
    Scene ret = (cPtr == global::System.IntPtr.Zero) ? null : new Scene(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_Diamond__WindowCanvas CreateWindowCanvas() {
    global::System.IntPtr cPtr = Diamond_SharedPINVOKE.Core_CreateWindowCanvas(swigCPtr);
    SWIGTYPE_p_Diamond__WindowCanvas ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Diamond__WindowCanvas(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_Diamond__InteractiveViewer CreateInteractiveViewer() {
    global::System.IntPtr cPtr = Diamond_SharedPINVOKE.Core_CreateInteractiveViewer(swigCPtr);
    SWIGTYPE_p_Diamond__InteractiveViewer ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Diamond__InteractiveViewer(cPtr, false);
    return ret;
  }

  public bool Update() {
    bool ret = Diamond_SharedPINVOKE.Core_Update(swigCPtr);
    return ret;
  }

  public void Release(Scene pScene) {
    Diamond_SharedPINVOKE.Core_Release__SWIG_0(swigCPtr, Scene.getCPtr(pScene));
  }

  public void Release(SWIGTYPE_p_Diamond__WindowCanvas pCanvas) {
    Diamond_SharedPINVOKE.Core_Release__SWIG_1(swigCPtr, SWIGTYPE_p_Diamond__WindowCanvas.getCPtr(pCanvas));
  }

  public void Release(SWIGTYPE_p_Diamond__InteractiveViewer pViewer) {
    Diamond_SharedPINVOKE.Core_Release__SWIG_2(swigCPtr, SWIGTYPE_p_Diamond__InteractiveViewer.getCPtr(pViewer));
  }

}

}
