/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class Matrix4x4 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Matrix4x4(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Matrix4x4 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Matrix4x4() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RockPINVOKE.delete_Matrix4x4(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public float _11 {
    set {
      RockPINVOKE.Matrix4x4__11_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Matrix4x4__11_get(swigCPtr);
      return ret;
    } 
  }

  public float _12 {
    set {
      RockPINVOKE.Matrix4x4__12_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Matrix4x4__12_get(swigCPtr);
      return ret;
    } 
  }

  public float _13 {
    set {
      RockPINVOKE.Matrix4x4__13_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Matrix4x4__13_get(swigCPtr);
      return ret;
    } 
  }

  public float _14 {
    set {
      RockPINVOKE.Matrix4x4__14_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Matrix4x4__14_get(swigCPtr);
      return ret;
    } 
  }

  public float _21 {
    set {
      RockPINVOKE.Matrix4x4__21_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Matrix4x4__21_get(swigCPtr);
      return ret;
    } 
  }

  public float _22 {
    set {
      RockPINVOKE.Matrix4x4__22_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Matrix4x4__22_get(swigCPtr);
      return ret;
    } 
  }

  public float _23 {
    set {
      RockPINVOKE.Matrix4x4__23_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Matrix4x4__23_get(swigCPtr);
      return ret;
    } 
  }

  public float _24 {
    set {
      RockPINVOKE.Matrix4x4__24_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Matrix4x4__24_get(swigCPtr);
      return ret;
    } 
  }

  public float _31 {
    set {
      RockPINVOKE.Matrix4x4__31_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Matrix4x4__31_get(swigCPtr);
      return ret;
    } 
  }

  public float _32 {
    set {
      RockPINVOKE.Matrix4x4__32_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Matrix4x4__32_get(swigCPtr);
      return ret;
    } 
  }

  public float _33 {
    set {
      RockPINVOKE.Matrix4x4__33_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Matrix4x4__33_get(swigCPtr);
      return ret;
    } 
  }

  public float _34 {
    set {
      RockPINVOKE.Matrix4x4__34_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Matrix4x4__34_get(swigCPtr);
      return ret;
    } 
  }

  public float _41 {
    set {
      RockPINVOKE.Matrix4x4__41_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Matrix4x4__41_get(swigCPtr);
      return ret;
    } 
  }

  public float _42 {
    set {
      RockPINVOKE.Matrix4x4__42_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Matrix4x4__42_get(swigCPtr);
      return ret;
    } 
  }

  public float _43 {
    set {
      RockPINVOKE.Matrix4x4__43_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Matrix4x4__43_get(swigCPtr);
      return ret;
    } 
  }

  public float _44 {
    set {
      RockPINVOKE.Matrix4x4__44_set(swigCPtr, value);
    } 
    get {
      float ret = RockPINVOKE.Matrix4x4__44_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_a_4__RFLOAT rc {
    set {
      RockPINVOKE.Matrix4x4_rc_set(swigCPtr, SWIGTYPE_p_a_4__RFLOAT.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = RockPINVOKE.Matrix4x4_rc_get(swigCPtr);
      SWIGTYPE_p_a_4__RFLOAT ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_a_4__RFLOAT(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_RFLOAT v {
    set {
      RockPINVOKE.Matrix4x4_v_set(swigCPtr, SWIGTYPE_p_RFLOAT.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = RockPINVOKE.Matrix4x4_v_get(swigCPtr);
      SWIGTYPE_p_RFLOAT ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_RFLOAT(cPtr, false);
      return ret;
    } 
  }

  public Matrix4x4() : this(RockPINVOKE.new_Matrix4x4__SWIG_0(), true) {
  }

  public Matrix4x4(Matrix4x4 mCopy) : this(RockPINVOKE.new_Matrix4x4__SWIG_1(Matrix4x4.getCPtr(mCopy)), true) {
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRow(SWIGTYPE_p_RINT nRow, Vector4 vRow) {
    RockPINVOKE.Matrix4x4_SetRow__SWIG_0(swigCPtr, SWIGTYPE_p_RINT.getCPtr(nRow), Vector4.getCPtr(vRow));
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRow(SWIGTYPE_p_RINT nRow, float n0, float n1, float n2, float n3) {
    RockPINVOKE.Matrix4x4_SetRow__SWIG_1(swigCPtr, SWIGTYPE_p_RINT.getCPtr(nRow), n0, n1, n2, n3);
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetColumn(SWIGTYPE_p_RINT nColumn, Vector4 vColumn) {
    RockPINVOKE.Matrix4x4_SetColumn__SWIG_0(swigCPtr, SWIGTYPE_p_RINT.getCPtr(nColumn), Vector4.getCPtr(vColumn));
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetColumn(SWIGTYPE_p_RINT nColumn, float n0, float n1, float n2, float n3) {
    RockPINVOKE.Matrix4x4_SetColumn__SWIG_1(swigCPtr, SWIGTYPE_p_RINT.getCPtr(nColumn), n0, n1, n2, n3);
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAxisX(Vector3 vAxis) {
    RockPINVOKE.Matrix4x4_SetAxisX__SWIG_0(swigCPtr, Vector3.getCPtr(vAxis));
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAxisX(float x, float y, float z) {
    RockPINVOKE.Matrix4x4_SetAxisX__SWIG_1(swigCPtr, x, y, z);
  }

  public void SetAxisY(Vector3 vAxis) {
    RockPINVOKE.Matrix4x4_SetAxisY__SWIG_0(swigCPtr, Vector3.getCPtr(vAxis));
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAxisY(float x, float y, float z) {
    RockPINVOKE.Matrix4x4_SetAxisY__SWIG_1(swigCPtr, x, y, z);
  }

  public void SetAxisZ(Vector3 vAxis) {
    RockPINVOKE.Matrix4x4_SetAxisZ__SWIG_0(swigCPtr, Vector3.getCPtr(vAxis));
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAxisZ(float x, float y, float z) {
    RockPINVOKE.Matrix4x4_SetAxisZ__SWIG_1(swigCPtr, x, y, z);
  }

  public void SetPosition(Vector3 vPosition) {
    RockPINVOKE.Matrix4x4_SetPosition__SWIG_0(swigCPtr, Vector3.getCPtr(vPosition));
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetPosition(float x, float y, float z) {
    RockPINVOKE.Matrix4x4_SetPosition__SWIG_1(swigCPtr, x, y, z);
  }

  public void SetCell(SWIGTYPE_p_RINT nRow, SWIGTYPE_p_RINT nColumn, float nCell) {
    RockPINVOKE.Matrix4x4_SetCell(swigCPtr, SWIGTYPE_p_RINT.getCPtr(nRow), SWIGTYPE_p_RINT.getCPtr(nColumn), nCell);
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector4 GetRow(SWIGTYPE_p_RINT nRow) {
    Vector4 ret = new Vector4(RockPINVOKE.Matrix4x4_GetRow__SWIG_0(swigCPtr, SWIGTYPE_p_RINT.getCPtr(nRow)), true);
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 GetColumn(SWIGTYPE_p_RINT nColumn) {
    Vector4 ret = new Vector4(RockPINVOKE.Matrix4x4_GetColumn__SWIG_0(swigCPtr, SWIGTYPE_p_RINT.getCPtr(nColumn)), true);
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector3 GetAxisX() {
    Vector3 ret = new Vector3(RockPINVOKE.Matrix4x4_GetAxisX__SWIG_0(swigCPtr), true);
    return ret;
  }

  public Vector3 GetAxisY() {
    Vector3 ret = new Vector3(RockPINVOKE.Matrix4x4_GetAxisY__SWIG_0(swigCPtr), true);
    return ret;
  }

  public Vector3 GetAxisZ() {
    Vector3 ret = new Vector3(RockPINVOKE.Matrix4x4_GetAxisZ__SWIG_0(swigCPtr), true);
    return ret;
  }

  public Vector3 GetPosition() {
    Vector3 ret = new Vector3(RockPINVOKE.Matrix4x4_GetPosition__SWIG_0(swigCPtr), true);
    return ret;
  }

  public float GetCell(SWIGTYPE_p_RINT nRow, SWIGTYPE_p_RINT nColumn) {
    float ret = RockPINVOKE.Matrix4x4_GetCell__SWIG_0(swigCPtr, SWIGTYPE_p_RINT.getCPtr(nRow), SWIGTYPE_p_RINT.getCPtr(nColumn));
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetRow(SWIGTYPE_p_RINT nRow, Vector4 o_vRow) {
    RockPINVOKE.Matrix4x4_GetRow__SWIG_1(swigCPtr, SWIGTYPE_p_RINT.getCPtr(nRow), Vector4.getCPtr(o_vRow));
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetColumn(SWIGTYPE_p_RINT nColumn, Vector4 o_vColumn) {
    RockPINVOKE.Matrix4x4_GetColumn__SWIG_1(swigCPtr, SWIGTYPE_p_RINT.getCPtr(nColumn), Vector4.getCPtr(o_vColumn));
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetAxisX(Vector3 o_vAxis) {
    RockPINVOKE.Matrix4x4_GetAxisX__SWIG_1(swigCPtr, Vector3.getCPtr(o_vAxis));
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetAxisY(Vector3 o_vAxis) {
    RockPINVOKE.Matrix4x4_GetAxisY__SWIG_1(swigCPtr, Vector3.getCPtr(o_vAxis));
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetAxisZ(Vector3 o_vAxis) {
    RockPINVOKE.Matrix4x4_GetAxisZ__SWIG_1(swigCPtr, Vector3.getCPtr(o_vAxis));
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetPosition(Vector3 o_vPosition) {
    RockPINVOKE.Matrix4x4_GetPosition__SWIG_1(swigCPtr, Vector3.getCPtr(o_vPosition));
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetCell(SWIGTYPE_p_RINT nRow, SWIGTYPE_p_RINT nColumn, SWIGTYPE_p_RFLOAT o_nValue) {
    RockPINVOKE.Matrix4x4_GetCell__SWIG_1(swigCPtr, SWIGTYPE_p_RINT.getCPtr(nRow), SWIGTYPE_p_RINT.getCPtr(nColumn), SWIGTYPE_p_RFLOAT.getCPtr(o_nValue));
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Identity() {
    RockPINVOKE.Matrix4x4_Identity(swigCPtr);
  }

  public void Inverse() {
    RockPINVOKE.Matrix4x4_Inverse(swigCPtr);
  }

  public void Transpose() {
    RockPINVOKE.Matrix4x4_Transpose(swigCPtr);
  }

  public Matrix4x4 Inversed() {
    Matrix4x4 ret = new Matrix4x4(RockPINVOKE.Matrix4x4_Inversed__SWIG_0(swigCPtr), true);
    return ret;
  }

  public Matrix4x4 Transposed() {
    Matrix4x4 ret = new Matrix4x4(RockPINVOKE.Matrix4x4_Transposed__SWIG_0(swigCPtr), true);
    return ret;
  }

  public void Inversed(Matrix4x4 o_mInversed) {
    RockPINVOKE.Matrix4x4_Inversed__SWIG_1(swigCPtr, Matrix4x4.getCPtr(o_mInversed));
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Transposed(Matrix4x4 o_mTransposed) {
    RockPINVOKE.Matrix4x4_Transposed__SWIG_1(swigCPtr, Matrix4x4.getCPtr(o_mTransposed));
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
  }

  public static Matrix4x4 CreatePerspectiveLH(float nFOV, float nAspectRatio, float nNearClipping, float nFarClipping) {
    Matrix4x4 ret = new Matrix4x4(RockPINVOKE.Matrix4x4_CreatePerspectiveLH(nFOV, nAspectRatio, nNearClipping, nFarClipping), true);
    return ret;
  }

  public static Matrix4x4 CreatePerspectiveRH(float nFOV, float nAspectRatio, float nNearClipping, float nFarClipping) {
    Matrix4x4 ret = new Matrix4x4(RockPINVOKE.Matrix4x4_CreatePerspectiveRH(nFOV, nAspectRatio, nNearClipping, nFarClipping), true);
    return ret;
  }

  public static Matrix4x4 CreateIdentity() {
    Matrix4x4 ret = new Matrix4x4(RockPINVOKE.Matrix4x4_CreateIdentity(), true);
    return ret;
  }

  public static Matrix4x4 CreateViewLH(Vector3 vPosition, Vector3 vLookat, Vector3 vUp) {
    Matrix4x4 ret = new Matrix4x4(RockPINVOKE.Matrix4x4_CreateViewLH(Vector3.getCPtr(vPosition), Vector3.getCPtr(vLookat), Vector3.getCPtr(vUp)), true);
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Matrix4x4 CreateViewRH(Vector3 vPosition, Vector3 vLookat, Vector3 vUp) {
    Matrix4x4 ret = new Matrix4x4(RockPINVOKE.Matrix4x4_CreateViewRH(Vector3.getCPtr(vPosition), Vector3.getCPtr(vLookat), Vector3.getCPtr(vUp)), true);
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Matrix4x4 CreateScale(Vector3 vScale) {
    Matrix4x4 ret = new Matrix4x4(RockPINVOKE.Matrix4x4_CreateScale(Vector3.getCPtr(vScale)), true);
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Matrix4x4 CreateTranslate(Vector3 vTranslation) {
    Matrix4x4 ret = new Matrix4x4(RockPINVOKE.Matrix4x4_CreateTranslate(Vector3.getCPtr(vTranslation)), true);
    if (RockPINVOKE.SWIGPendingException.Pending) throw RockPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Matrix4x4 CreateRotateX(float nRot) {
    Matrix4x4 ret = new Matrix4x4(RockPINVOKE.Matrix4x4_CreateRotateX(nRot), true);
    return ret;
  }

  public static Matrix4x4 CreateRotateY(float nRot) {
    Matrix4x4 ret = new Matrix4x4(RockPINVOKE.Matrix4x4_CreateRotateY(nRot), true);
    return ret;
  }

  public static Matrix4x4 CreateRotateZ(float nRot) {
    Matrix4x4 ret = new Matrix4x4(RockPINVOKE.Matrix4x4_CreateRotateZ(nRot), true);
    return ret;
  }

}
