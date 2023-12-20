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

public class MediaFrame : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MediaFrame(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MediaFrame obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(MediaFrame obj) {
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

  ~MediaFrame() {
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
          pjsua2PINVOKE.delete_MediaFrame(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public pjmedia_frame_type type {
    set {
      pjsua2PINVOKE.MediaFrame_type_set(swigCPtr, (int)value);
    } 
    get {
      pjmedia_frame_type ret = (pjmedia_frame_type)pjsua2PINVOKE.MediaFrame_type_get(swigCPtr);
      return ret;
    } 
  }

  public ByteVector buf {
    set {
      pjsua2PINVOKE.MediaFrame_buf_set(swigCPtr, ByteVector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.MediaFrame_buf_get(swigCPtr);
      ByteVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new ByteVector(cPtr, false);
      return ret;
    } 
  }

  public uint size {
    set {
      pjsua2PINVOKE.MediaFrame_size_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaFrame_size_get(swigCPtr);
      return ret;
    } 
  }

  public MediaFrame() : this(pjsua2PINVOKE.new_MediaFrame(), true) {
  }

}

}
