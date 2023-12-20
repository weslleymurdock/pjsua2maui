//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pjsua2maui.pjsua2 {

public class AccountPresConfig : PersistentObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal AccountPresConfig(global::System.IntPtr cPtr, bool cMemoryOwn) : base(pjsua2PINVOKE.AccountPresConfig_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AccountPresConfig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(AccountPresConfig obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_AccountPresConfig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public SipHeaderVector headers {
    set {
      pjsua2PINVOKE.AccountPresConfig_headers_set(swigCPtr, SipHeaderVector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.AccountPresConfig_headers_get(swigCPtr);
      SipHeaderVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new SipHeaderVector(cPtr, false);
      return ret;
    } 
  }

  public bool publishEnabled {
    set {
      pjsua2PINVOKE.AccountPresConfig_publishEnabled_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.AccountPresConfig_publishEnabled_get(swigCPtr);
      return ret;
    } 
  }

  public bool publishQueue {
    set {
      pjsua2PINVOKE.AccountPresConfig_publishQueue_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.AccountPresConfig_publishQueue_get(swigCPtr);
      return ret;
    } 
  }

  public uint publishShutdownWaitMsec {
    set {
      pjsua2PINVOKE.AccountPresConfig_publishShutdownWaitMsec_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.AccountPresConfig_publishShutdownWaitMsec_get(swigCPtr);
      return ret;
    } 
  }

  public string pidfTupleId {
    set {
      pjsua2PINVOKE.AccountPresConfig_pidfTupleId_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.AccountPresConfig_pidfTupleId_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public override void readObject(ContainerNode node) {
    pjsua2PINVOKE.AccountPresConfig_readObject(swigCPtr, ContainerNode.getCPtr(node));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public override void writeObject(ContainerNode node) {
    pjsua2PINVOKE.AccountPresConfig_writeObject(swigCPtr, ContainerNode.getCPtr(node));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public AccountPresConfig() : this(pjsua2PINVOKE.new_AccountPresConfig(), true) {
  }

}

}
