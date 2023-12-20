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

public class BuddyConfig : PersistentObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal BuddyConfig(global::System.IntPtr cPtr, bool cMemoryOwn) : base(pjsua2PINVOKE.BuddyConfig_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BuddyConfig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_BuddyConfig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public string uri {
    set {
      pjsua2PINVOKE.BuddyConfig_uri_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.BuddyConfig_uri_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool subscribe {
    set {
      pjsua2PINVOKE.BuddyConfig_subscribe_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.BuddyConfig_subscribe_get(swigCPtr);
      return ret;
    } 
  }

  public override void readObject(ContainerNode node) {
    pjsua2PINVOKE.BuddyConfig_readObject(swigCPtr, ContainerNode.getCPtr(node));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public override void writeObject(ContainerNode node) {
    pjsua2PINVOKE.BuddyConfig_writeObject(swigCPtr, ContainerNode.getCPtr(node));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public BuddyConfig() : this(pjsua2PINVOKE.new_BuddyConfig(), true) {
  }

}

}
