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

public class AudioMedia : Media {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal AudioMedia(global::System.IntPtr cPtr, bool cMemoryOwn) : base(pjsua2PINVOKE.AudioMedia_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AudioMedia obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(AudioMedia obj) {
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
          pjsua2PINVOKE.delete_AudioMedia(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ConfPortInfo getPortInfo() {
    ConfPortInfo ret = new ConfPortInfo(pjsua2PINVOKE.AudioMedia_getPortInfo(swigCPtr), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getPortId() {
    int ret = pjsua2PINVOKE.AudioMedia_getPortId(swigCPtr);
    return ret;
  }

  public static ConfPortInfo getPortInfoFromId(int port_id) {
    ConfPortInfo ret = new ConfPortInfo(pjsua2PINVOKE.AudioMedia_getPortInfoFromId(port_id), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void startTransmit(AudioMedia sink) {
    pjsua2PINVOKE.AudioMedia_startTransmit(swigCPtr, AudioMedia.getCPtr(sink));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void startTransmit2(AudioMedia sink, AudioMediaTransmitParam param) {
    pjsua2PINVOKE.AudioMedia_startTransmit2(swigCPtr, AudioMedia.getCPtr(sink), AudioMediaTransmitParam.getCPtr(param));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void stopTransmit(AudioMedia sink) {
    pjsua2PINVOKE.AudioMedia_stopTransmit(swigCPtr, AudioMedia.getCPtr(sink));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void adjustRxLevel(float level) {
    pjsua2PINVOKE.AudioMedia_adjustRxLevel(swigCPtr, level);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void adjustTxLevel(float level) {
    pjsua2PINVOKE.AudioMedia_adjustTxLevel(swigCPtr, level);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getRxLevel() {
    uint ret = pjsua2PINVOKE.AudioMedia_getRxLevel(swigCPtr);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getTxLevel() {
    uint ret = pjsua2PINVOKE.AudioMedia_getTxLevel(swigCPtr);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static AudioMedia typecastFromMedia(Media media) {
    global::System.IntPtr cPtr = pjsua2PINVOKE.AudioMedia_typecastFromMedia(Media.getCPtr(media));
    AudioMedia ret = (cPtr == global::System.IntPtr.Zero) ? null : new AudioMedia(cPtr, false);
    return ret;
  }

  public AudioMedia() : this(pjsua2PINVOKE.new_AudioMedia(), true) {
  }

}

}
