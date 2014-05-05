/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class Vector4 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Vector4(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Vector4 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Vector4() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RockPINVOKE.delete_Vector4(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public float x {
    set {
      RockPINVOKE.Vector4_x_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Vector4_x_get(swigCPtr);
      return ret;
    } 
  }

  public float y {
    set {
      RockPINVOKE.Vector4_y_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Vector4_y_get(swigCPtr);
      return ret;
    } 
  }

  public float z {
    set {
      RockPINVOKE.Vector4_z_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Vector4_z_get(swigCPtr);
      return ret;
    } 
  }

  public float w {
    set {
      RockPINVOKE.Vector4_w_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Vector4_w_get(swigCPtr);
      return ret;
    } 
  }

  public Vector4() : this(RockPINVOKE.new_Vector4__SWIG_0(), true) {
  }

  public Vector4(float v) : this(RockPINVOKE.new_Vector4__SWIG_1(v), true) {
  }

  public Vector4(Vector4 vVector) : this(RockPINVOKE.new_Vector4__SWIG_2(Vector4.getCPtr(vVector)), true) {
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector4(Vector3 vVector, float w) : this(RockPINVOKE.new_Vector4__SWIG_3(Vector3.getCPtr(vVector), w), true) {
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector4(Vector3 vVector) : this(RockPINVOKE.new_Vector4__SWIG_4(Vector3.getCPtr(vVector)), true) {
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector4(float x, float y, float z, float w) : this(RockPINVOKE.new_Vector4__SWIG_5(x, y, z, w), true) {
  }

  public Vector4(float x, float y, float z) : this(RockPINVOKE.new_Vector4__SWIG_6(x, y, z), true) {
  }

  public float Dot(Vector4 vVector) {
    float ret = RockPINVOKE.Vector4_Dot__SWIG_0(swigCPtr, Vector4.getCPtr(vVector));
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Dot(Vector4 vVector, SWIGTYPE_p_RFLOAT o_nDot) {
    RockPINVOKE.Vector4_Dot__SWIG_1(swigCPtr, Vector4.getCPtr(vVector), SWIGTYPE_p_RFLOAT.getCPtr(o_nDot));
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

}
