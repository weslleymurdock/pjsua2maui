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

public class MediaFormat : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MediaFormat(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MediaFormat obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MediaFormat() {
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
          pjsua2PINVOKE.delete_MediaFormat(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint id {
    set {
      pjsua2PINVOKE.MediaFormat_id_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaFormat_id_get(swigCPtr);
      return ret;
    } 
  }

  public pjmedia_type type {
    set {
      pjsua2PINVOKE.MediaFormat_type_set(swigCPtr, (int)value);
    } 
    get {
      pjmedia_type ret = (pjmedia_type)pjsua2PINVOKE.MediaFormat_type_get(swigCPtr);
      return ret;
    } 
  }

  public MediaFormat() : this(pjsua2PINVOKE.new_MediaFormat(), true) {
  }

}

}
