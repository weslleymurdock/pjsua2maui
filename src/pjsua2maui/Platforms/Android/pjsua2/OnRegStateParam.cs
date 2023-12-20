//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pjsua2maui.pjsua2 {

public class OnRegStateParam : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OnRegStateParam(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OnRegStateParam obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~OnRegStateParam() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_OnRegStateParam(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public int status {
    set {
      pjsua2PINVOKE.OnRegStateParam_status_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.OnRegStateParam_status_get(swigCPtr);
      return ret;
    } 
  }

  public pjsip_status_code code {
    set {
      pjsua2PINVOKE.OnRegStateParam_code_set(swigCPtr, (int)value);
    } 
    get {
      pjsip_status_code ret = (pjsip_status_code)pjsua2PINVOKE.OnRegStateParam_code_get(swigCPtr);
      return ret;
    } 
  }

  public string reason {
    set {
      pjsua2PINVOKE.OnRegStateParam_reason_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.OnRegStateParam_reason_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SipRxData rdata {
    set {
      pjsua2PINVOKE.OnRegStateParam_rdata_set(swigCPtr, SipRxData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.OnRegStateParam_rdata_get(swigCPtr);
      SipRxData ret = (cPtr == global::System.IntPtr.Zero) ? null : new SipRxData(cPtr, false);
      return ret;
    } 
  }

  public uint expiration {
    set {
      pjsua2PINVOKE.OnRegStateParam_expiration_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.OnRegStateParam_expiration_get(swigCPtr);
      return ret;
    } 
  }

  public OnRegStateParam() : this(pjsua2PINVOKE.new_OnRegStateParam(), true) {
  }

}

}
