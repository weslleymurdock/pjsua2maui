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

public class SendTypingIndicationParam : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SendTypingIndicationParam(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SendTypingIndicationParam obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SendTypingIndicationParam() {
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
          pjsua2PINVOKE.delete_SendTypingIndicationParam(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public bool isTyping {
    set {
      pjsua2PINVOKE.SendTypingIndicationParam_isTyping_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.SendTypingIndicationParam_isTyping_get(swigCPtr);
      return ret;
    } 
  }

  public SipTxOption txOption {
    set {
      pjsua2PINVOKE.SendTypingIndicationParam_txOption_set(swigCPtr, SipTxOption.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.SendTypingIndicationParam_txOption_get(swigCPtr);
      SipTxOption ret = (cPtr == global::System.IntPtr.Zero) ? null : new SipTxOption(cPtr, false);
      return ret;
    } 
  }

  public SendTypingIndicationParam() : this(pjsua2PINVOKE.new_SendTypingIndicationParam(), true) {
  }

}

}
