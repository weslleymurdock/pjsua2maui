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

public class MediaEvent : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MediaEvent(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MediaEvent obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MediaEvent() {
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
          pjsua2PINVOKE.delete_MediaEvent(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public pjmedia_event_type type {
    set {
      pjsua2PINVOKE.MediaEvent_type_set(swigCPtr, (int)value);
    } 
    get {
      pjmedia_event_type ret = (pjmedia_event_type)pjsua2PINVOKE.MediaEvent_type_get(swigCPtr);
      return ret;
    } 
  }

  public MediaEventData data {
    set {
      pjsua2PINVOKE.MediaEvent_data_set(swigCPtr, MediaEventData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.MediaEvent_data_get(swigCPtr);
      MediaEventData ret = (cPtr == global::System.IntPtr.Zero) ? null : new MediaEventData(cPtr, false);
      return ret;
    } 
  }

  public System.IntPtr pjMediaEvent {
    set {
      pjsua2PINVOKE.MediaEvent_pjMediaEvent_set(swigCPtr, value);
    } 
    get {
        System.IntPtr cPtr = pjsua2PINVOKE.MediaEvent_pjMediaEvent_get(swigCPtr);
        return cPtr;
    }
  
  }

  public MediaEvent() : this(pjsua2PINVOKE.new_MediaEvent(), true) {
  }

}

}
