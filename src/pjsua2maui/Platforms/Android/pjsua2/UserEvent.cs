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

public class UserEvent : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UserEvent(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UserEvent obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UserEvent() {
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
          pjsua2PINVOKE.delete_UserEvent(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public System.IntPtr user1 {
    set {
      pjsua2PINVOKE.UserEvent_user1_set(swigCPtr, value);
    } 
    get {
        System.IntPtr cPtr = pjsua2PINVOKE.UserEvent_user1_get(swigCPtr);
        return cPtr;
    }
  
  }

  public System.IntPtr user2 {
    set {
      pjsua2PINVOKE.UserEvent_user2_set(swigCPtr, value);
    } 
    get {
        System.IntPtr cPtr = pjsua2PINVOKE.UserEvent_user2_get(swigCPtr);
        return cPtr;
    }
  
  }

  public System.IntPtr user3 {
    set {
      pjsua2PINVOKE.UserEvent_user3_set(swigCPtr, value);
    } 
    get {
        System.IntPtr cPtr = pjsua2PINVOKE.UserEvent_user3_get(swigCPtr);
        return cPtr;
    }
  
  }

  public System.IntPtr user4 {
    set {
      pjsua2PINVOKE.UserEvent_user4_set(swigCPtr, value);
    } 
    get {
        System.IntPtr cPtr = pjsua2PINVOKE.UserEvent_user4_get(swigCPtr);
        return cPtr;
    }
  
  }

  public UserEvent() : this(pjsua2PINVOKE.new_UserEvent(), true) {
  }

}

}
