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

public class OnInstantMessageStatusParam : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OnInstantMessageStatusParam(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OnInstantMessageStatusParam obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~OnInstantMessageStatusParam() {
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
          pjsua2PINVOKE.delete_OnInstantMessageStatusParam(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public System.IntPtr userData {
    set {
      pjsua2PINVOKE.OnInstantMessageStatusParam_userData_set(swigCPtr, value);
    } 
    get {
        System.IntPtr cPtr = pjsua2PINVOKE.OnInstantMessageStatusParam_userData_get(swigCPtr);
        return cPtr;
    }
  
  }

  public string toUri {
    set {
      pjsua2PINVOKE.OnInstantMessageStatusParam_toUri_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.OnInstantMessageStatusParam_toUri_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string msgBody {
    set {
      pjsua2PINVOKE.OnInstantMessageStatusParam_msgBody_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.OnInstantMessageStatusParam_msgBody_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public pjsip_status_code code {
    set {
      pjsua2PINVOKE.OnInstantMessageStatusParam_code_set(swigCPtr, (int)value);
    } 
    get {
      pjsip_status_code ret = (pjsip_status_code)pjsua2PINVOKE.OnInstantMessageStatusParam_code_get(swigCPtr);
      return ret;
    } 
  }

  public string reason {
    set {
      pjsua2PINVOKE.OnInstantMessageStatusParam_reason_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.OnInstantMessageStatusParam_reason_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SipRxData rdata {
    set {
      pjsua2PINVOKE.OnInstantMessageStatusParam_rdata_set(swigCPtr, SipRxData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.OnInstantMessageStatusParam_rdata_get(swigCPtr);
      SipRxData ret = (cPtr == global::System.IntPtr.Zero) ? null : new SipRxData(cPtr, false);
      return ret;
    } 
  }

  public OnInstantMessageStatusParam() : this(pjsua2PINVOKE.new_OnInstantMessageStatusParam(), true) {
  }

}

}
