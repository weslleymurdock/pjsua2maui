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

public class VideoWindowHandle : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VideoWindowHandle(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VideoWindowHandle obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VideoWindowHandle() {
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
          pjsua2PINVOKE.delete_VideoWindowHandle(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_pjmedia_vid_dev_hwnd_type type {
    set {
      pjsua2PINVOKE.VideoWindowHandle_type_set(swigCPtr, SWIGTYPE_p_pjmedia_vid_dev_hwnd_type.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_pjmedia_vid_dev_hwnd_type ret = new SWIGTYPE_p_pjmedia_vid_dev_hwnd_type(pjsua2PINVOKE.VideoWindowHandle_type_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public WindowHandle handle {
    set {
      pjsua2PINVOKE.VideoWindowHandle_handle_set(swigCPtr, WindowHandle.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.VideoWindowHandle_handle_get(swigCPtr);
      WindowHandle ret = (cPtr == global::System.IntPtr.Zero) ? null : new WindowHandle(cPtr, false);
      return ret;
    } 
  }

  public VideoWindowHandle() : this(pjsua2PINVOKE.new_VideoWindowHandle(), true) {
  }

}

}
