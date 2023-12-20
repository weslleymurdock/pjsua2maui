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

public class VideoMedia : Media {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal VideoMedia(global::System.IntPtr cPtr, bool cMemoryOwn) : base(pjsua2PINVOKE.VideoMedia_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VideoMedia obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(VideoMedia obj) {
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
          pjsua2PINVOKE.delete_VideoMedia(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public VidConfPortInfo getPortInfo() {
    VidConfPortInfo ret = new VidConfPortInfo(pjsua2PINVOKE.VideoMedia_getPortInfo(swigCPtr), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getPortId() {
    int ret = pjsua2PINVOKE.VideoMedia_getPortId(swigCPtr);
    return ret;
  }

  public static VidConfPortInfo getPortInfoFromId(int port_id) {
    VidConfPortInfo ret = new VidConfPortInfo(pjsua2PINVOKE.VideoMedia_getPortInfoFromId(port_id), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void startTransmit(VideoMedia sink, VideoMediaTransmitParam param) {
    pjsua2PINVOKE.VideoMedia_startTransmit(swigCPtr, VideoMedia.getCPtr(sink), VideoMediaTransmitParam.getCPtr(param));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void stopTransmit(VideoMedia sink) {
    pjsua2PINVOKE.VideoMedia_stopTransmit(swigCPtr, VideoMedia.getCPtr(sink));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void update() {
    pjsua2PINVOKE.VideoMedia_update(swigCPtr);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public VideoMedia() : this(pjsua2PINVOKE.new_VideoMedia(), true) {
  }

}

}
