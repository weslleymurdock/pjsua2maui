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

public class TsxStateEventSrc : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TsxStateEventSrc(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TsxStateEventSrc obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TsxStateEventSrc() {
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
          pjsua2PINVOKE.delete_TsxStateEventSrc(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SipRxData rdata {
    set {
      pjsua2PINVOKE.TsxStateEventSrc_rdata_set(swigCPtr, SipRxData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.TsxStateEventSrc_rdata_get(swigCPtr);
      SipRxData ret = (cPtr == global::System.IntPtr.Zero) ? null : new SipRxData(cPtr, false);
      return ret;
    } 
  }

  public SipTxData tdata {
    set {
      pjsua2PINVOKE.TsxStateEventSrc_tdata_set(swigCPtr, SipTxData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.TsxStateEventSrc_tdata_get(swigCPtr);
      SipTxData ret = (cPtr == global::System.IntPtr.Zero) ? null : new SipTxData(cPtr, false);
      return ret;
    } 
  }

  public System.IntPtr timer {
    set {
      pjsua2PINVOKE.TsxStateEventSrc_timer_set(swigCPtr, value);
    } 
    get {
        System.IntPtr cPtr = pjsua2PINVOKE.TsxStateEventSrc_timer_get(swigCPtr);
        return cPtr;
    }
  
  }

  public int status {
    set {
      pjsua2PINVOKE.TsxStateEventSrc_status_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.TsxStateEventSrc_status_get(swigCPtr);
      return ret;
    } 
  }

  public System.IntPtr data {
    set {
      pjsua2PINVOKE.TsxStateEventSrc_data_set(swigCPtr, value);
    } 
    get {
        System.IntPtr cPtr = pjsua2PINVOKE.TsxStateEventSrc_data_get(swigCPtr);
        return cPtr;
    }
  
  }

  public TsxStateEventSrc() : this(pjsua2PINVOKE.new_TsxStateEventSrc(), true) {
  }

}

}
