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

public class Call : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Call(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Call obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(Call obj) {
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

  ~Call() {
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
          pjsua2PINVOKE.delete_Call(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Call(Account acc, int call_id) : this(pjsua2PINVOKE.new_Call__SWIG_0(Account.getCPtr(acc), call_id), true) {
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public Call(Account acc) : this(pjsua2PINVOKE.new_Call__SWIG_1(Account.getCPtr(acc)), true) {
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public CallInfo getInfo() {
    CallInfo ret = new CallInfo(pjsua2PINVOKE.Call_getInfo(swigCPtr), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isActive() {
    bool ret = pjsua2PINVOKE.Call_isActive(swigCPtr);
    return ret;
  }

  public int getId() {
    int ret = pjsua2PINVOKE.Call_getId(swigCPtr);
    return ret;
  }

  public static Call lookup(int call_id) {
    global::System.IntPtr cPtr = pjsua2PINVOKE.Call_lookup(call_id);
    Call ret = (cPtr == global::System.IntPtr.Zero) ? null : new Call(cPtr, false);
    return ret;
  }

  public bool hasMedia() {
    bool ret = pjsua2PINVOKE.Call_hasMedia(swigCPtr);
    return ret;
  }

  public Media getMedia(uint med_idx) {
    global::System.IntPtr cPtr = pjsua2PINVOKE.Call_getMedia(swigCPtr, med_idx);
    Media ret = (cPtr == global::System.IntPtr.Zero) ? null : new Media(cPtr, false);
    return ret;
  }

  public AudioMedia getAudioMedia(int med_idx) {
    AudioMedia ret = new AudioMedia(pjsua2PINVOKE.Call_getAudioMedia(swigCPtr, med_idx), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VideoMedia getEncodingVideoMedia(int med_idx) {
    VideoMedia ret = new VideoMedia(pjsua2PINVOKE.Call_getEncodingVideoMedia(swigCPtr, med_idx), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VideoMedia getDecodingVideoMedia(int med_idx) {
    VideoMedia ret = new VideoMedia(pjsua2PINVOKE.Call_getDecodingVideoMedia(swigCPtr, med_idx), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public pjsip_dialog_cap_status remoteHasCap(int htype, string hname, string token) {
    pjsip_dialog_cap_status ret = (pjsip_dialog_cap_status)pjsua2PINVOKE.Call_remoteHasCap(swigCPtr, htype, hname, token);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setUserData(System.IntPtr user_data) {
    pjsua2PINVOKE.Call_setUserData(swigCPtr, user_data);
  }

  public System.IntPtr getUserData() {
      System.IntPtr cPtr = pjsua2PINVOKE.Call_getUserData(swigCPtr);
      return cPtr;
  }

  public pj_stun_nat_type getRemNatType() {
    pj_stun_nat_type ret = (pj_stun_nat_type)pjsua2PINVOKE.Call_getRemNatType(swigCPtr);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void makeCall(string dst_uri, CallOpParam prm) {
    pjsua2PINVOKE.Call_makeCall(swigCPtr, dst_uri, CallOpParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void answer(CallOpParam prm) {
    pjsua2PINVOKE.Call_answer(swigCPtr, CallOpParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void hangup(CallOpParam prm) {
    pjsua2PINVOKE.Call_hangup(swigCPtr, CallOpParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void setHold(CallOpParam prm) {
    pjsua2PINVOKE.Call_setHold(swigCPtr, CallOpParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void reinvite(CallOpParam prm) {
    pjsua2PINVOKE.Call_reinvite(swigCPtr, CallOpParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void update(CallOpParam prm) {
    pjsua2PINVOKE.Call_update(swigCPtr, CallOpParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void xfer(string dest, CallOpParam prm) {
    pjsua2PINVOKE.Call_xfer(swigCPtr, dest, CallOpParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void xferReplaces(Call dest_call, CallOpParam prm) {
    pjsua2PINVOKE.Call_xferReplaces(swigCPtr, Call.getCPtr(dest_call), CallOpParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void processRedirect(pjsip_redirect_op cmd) {
    pjsua2PINVOKE.Call_processRedirect(swigCPtr, (int)cmd);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void dialDtmf(string digits) {
    pjsua2PINVOKE.Call_dialDtmf(swigCPtr, digits);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void sendDtmf(CallSendDtmfParam param) {
    pjsua2PINVOKE.Call_sendDtmf(swigCPtr, CallSendDtmfParam.getCPtr(param));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void sendInstantMessage(SendInstantMessageParam prm) {
    pjsua2PINVOKE.Call_sendInstantMessage(swigCPtr, SendInstantMessageParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void sendTypingIndication(SendTypingIndicationParam prm) {
    pjsua2PINVOKE.Call_sendTypingIndication(swigCPtr, SendTypingIndicationParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void sendRequest(CallSendRequestParam prm) {
    pjsua2PINVOKE.Call_sendRequest(swigCPtr, CallSendRequestParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public string dump(bool with_media, string indent) {
    string ret = pjsua2PINVOKE.Call_dump(swigCPtr, with_media, indent);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int vidGetStreamIdx() {
    int ret = pjsua2PINVOKE.Call_vidGetStreamIdx(swigCPtr);
    return ret;
  }

  public bool vidStreamIsRunning(int med_idx, pjmedia_dir dir) {
    bool ret = pjsua2PINVOKE.Call_vidStreamIsRunning(swigCPtr, med_idx, (int)dir);
    return ret;
  }

  public void vidSetStream(pjsua_call_vid_strm_op op, CallVidSetStreamParam param) {
    pjsua2PINVOKE.Call_vidSetStream(swigCPtr, (int)op, CallVidSetStreamParam.getCPtr(param));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void vidStreamModifyCodecParam(int med_idx, VidCodecParam param) {
    pjsua2PINVOKE.Call_vidStreamModifyCodecParam(swigCPtr, med_idx, VidCodecParam.getCPtr(param));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void audStreamModifyCodecParam(int med_idx, CodecParam param) {
    pjsua2PINVOKE.Call_audStreamModifyCodecParam(swigCPtr, med_idx, CodecParam.getCPtr(param));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamInfo getStreamInfo(uint med_idx) {
    StreamInfo ret = new StreamInfo(pjsua2PINVOKE.Call_getStreamInfo(swigCPtr, med_idx), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StreamStat getStreamStat(uint med_idx) {
    StreamStat ret = new StreamStat(pjsua2PINVOKE.Call_getStreamStat(swigCPtr, med_idx), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MediaTransportInfo getMedTransportInfo(uint med_idx) {
    MediaTransportInfo ret = new MediaTransportInfo(pjsua2PINVOKE.Call_getMedTransportInfo(swigCPtr, med_idx), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void processMediaUpdate(OnCallMediaStateParam prm) {
    pjsua2PINVOKE.Call_processMediaUpdate(swigCPtr, OnCallMediaStateParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void processStateChange(OnCallStateParam prm) {
    pjsua2PINVOKE.Call_processStateChange(swigCPtr, OnCallStateParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallState(OnCallStateParam prm) {
    if (SwigDerivedClassHasMethod("onCallState", swigMethodTypes0)) pjsua2PINVOKE.Call_onCallStateSwigExplicitCall(swigCPtr, OnCallStateParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onCallState(swigCPtr, OnCallStateParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallTsxState(OnCallTsxStateParam prm) {
    if (SwigDerivedClassHasMethod("onCallTsxState", swigMethodTypes1)) pjsua2PINVOKE.Call_onCallTsxStateSwigExplicitCall(swigCPtr, OnCallTsxStateParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onCallTsxState(swigCPtr, OnCallTsxStateParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallMediaState(OnCallMediaStateParam prm) {
    if (SwigDerivedClassHasMethod("onCallMediaState", swigMethodTypes2)) pjsua2PINVOKE.Call_onCallMediaStateSwigExplicitCall(swigCPtr, OnCallMediaStateParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onCallMediaState(swigCPtr, OnCallMediaStateParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallSdpCreated(OnCallSdpCreatedParam prm) {
    if (SwigDerivedClassHasMethod("onCallSdpCreated", swigMethodTypes3)) pjsua2PINVOKE.Call_onCallSdpCreatedSwigExplicitCall(swigCPtr, OnCallSdpCreatedParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onCallSdpCreated(swigCPtr, OnCallSdpCreatedParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onStreamPreCreate(OnStreamPreCreateParam prm) {
    if (SwigDerivedClassHasMethod("onStreamPreCreate", swigMethodTypes4)) pjsua2PINVOKE.Call_onStreamPreCreateSwigExplicitCall(swigCPtr, OnStreamPreCreateParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onStreamPreCreate(swigCPtr, OnStreamPreCreateParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onStreamCreated(OnStreamCreatedParam prm) {
    if (SwigDerivedClassHasMethod("onStreamCreated", swigMethodTypes5)) pjsua2PINVOKE.Call_onStreamCreatedSwigExplicitCall(swigCPtr, OnStreamCreatedParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onStreamCreated(swigCPtr, OnStreamCreatedParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onStreamDestroyed(OnStreamDestroyedParam prm) {
    if (SwigDerivedClassHasMethod("onStreamDestroyed", swigMethodTypes6)) pjsua2PINVOKE.Call_onStreamDestroyedSwigExplicitCall(swigCPtr, OnStreamDestroyedParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onStreamDestroyed(swigCPtr, OnStreamDestroyedParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onDtmfDigit(OnDtmfDigitParam prm) {
    if (SwigDerivedClassHasMethod("onDtmfDigit", swigMethodTypes7)) pjsua2PINVOKE.Call_onDtmfDigitSwigExplicitCall(swigCPtr, OnDtmfDigitParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onDtmfDigit(swigCPtr, OnDtmfDigitParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onDtmfEvent(OnDtmfEventParam prm) {
    if (SwigDerivedClassHasMethod("onDtmfEvent", swigMethodTypes8)) pjsua2PINVOKE.Call_onDtmfEventSwigExplicitCall(swigCPtr, OnDtmfEventParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onDtmfEvent(swigCPtr, OnDtmfEventParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallTransferRequest(OnCallTransferRequestParam prm) {
    if (SwigDerivedClassHasMethod("onCallTransferRequest", swigMethodTypes9)) pjsua2PINVOKE.Call_onCallTransferRequestSwigExplicitCall(swigCPtr, OnCallTransferRequestParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onCallTransferRequest(swigCPtr, OnCallTransferRequestParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallTransferStatus(OnCallTransferStatusParam prm) {
    if (SwigDerivedClassHasMethod("onCallTransferStatus", swigMethodTypes10)) pjsua2PINVOKE.Call_onCallTransferStatusSwigExplicitCall(swigCPtr, OnCallTransferStatusParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onCallTransferStatus(swigCPtr, OnCallTransferStatusParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallReplaceRequest(OnCallReplaceRequestParam prm) {
    if (SwigDerivedClassHasMethod("onCallReplaceRequest", swigMethodTypes11)) pjsua2PINVOKE.Call_onCallReplaceRequestSwigExplicitCall(swigCPtr, OnCallReplaceRequestParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onCallReplaceRequest(swigCPtr, OnCallReplaceRequestParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallReplaced(OnCallReplacedParam prm) {
    if (SwigDerivedClassHasMethod("onCallReplaced", swigMethodTypes12)) pjsua2PINVOKE.Call_onCallReplacedSwigExplicitCall(swigCPtr, OnCallReplacedParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onCallReplaced(swigCPtr, OnCallReplacedParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallRxOffer(OnCallRxOfferParam prm) {
    if (SwigDerivedClassHasMethod("onCallRxOffer", swigMethodTypes13)) pjsua2PINVOKE.Call_onCallRxOfferSwigExplicitCall(swigCPtr, OnCallRxOfferParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onCallRxOffer(swigCPtr, OnCallRxOfferParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallRxReinvite(OnCallRxReinviteParam prm) {
    if (SwigDerivedClassHasMethod("onCallRxReinvite", swigMethodTypes14)) pjsua2PINVOKE.Call_onCallRxReinviteSwigExplicitCall(swigCPtr, OnCallRxReinviteParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onCallRxReinvite(swigCPtr, OnCallRxReinviteParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallTxOffer(OnCallTxOfferParam prm) {
    if (SwigDerivedClassHasMethod("onCallTxOffer", swigMethodTypes15)) pjsua2PINVOKE.Call_onCallTxOfferSwigExplicitCall(swigCPtr, OnCallTxOfferParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onCallTxOffer(swigCPtr, OnCallTxOfferParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onInstantMessage(OnInstantMessageParam prm) {
    if (SwigDerivedClassHasMethod("onInstantMessage", swigMethodTypes16)) pjsua2PINVOKE.Call_onInstantMessageSwigExplicitCall(swigCPtr, OnInstantMessageParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onInstantMessage(swigCPtr, OnInstantMessageParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onInstantMessageStatus(OnInstantMessageStatusParam prm) {
    if (SwigDerivedClassHasMethod("onInstantMessageStatus", swigMethodTypes17)) pjsua2PINVOKE.Call_onInstantMessageStatusSwigExplicitCall(swigCPtr, OnInstantMessageStatusParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onInstantMessageStatus(swigCPtr, OnInstantMessageStatusParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onTypingIndication(OnTypingIndicationParam prm) {
    if (SwigDerivedClassHasMethod("onTypingIndication", swigMethodTypes18)) pjsua2PINVOKE.Call_onTypingIndicationSwigExplicitCall(swigCPtr, OnTypingIndicationParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onTypingIndication(swigCPtr, OnTypingIndicationParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual pjsip_redirect_op onCallRedirected(OnCallRedirectedParam prm) {
    pjsip_redirect_op ret = (pjsip_redirect_op)(SwigDerivedClassHasMethod("onCallRedirected", swigMethodTypes19) ? pjsua2PINVOKE.Call_onCallRedirectedSwigExplicitCall(swigCPtr, OnCallRedirectedParam.getCPtr(prm)) : pjsua2PINVOKE.Call_onCallRedirected(swigCPtr, OnCallRedirectedParam.getCPtr(prm)));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void onCallMediaTransportState(OnCallMediaTransportStateParam prm) {
    if (SwigDerivedClassHasMethod("onCallMediaTransportState", swigMethodTypes20)) pjsua2PINVOKE.Call_onCallMediaTransportStateSwigExplicitCall(swigCPtr, OnCallMediaTransportStateParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onCallMediaTransportState(swigCPtr, OnCallMediaTransportStateParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallMediaEvent(OnCallMediaEventParam prm) {
    if (SwigDerivedClassHasMethod("onCallMediaEvent", swigMethodTypes21)) pjsua2PINVOKE.Call_onCallMediaEventSwigExplicitCall(swigCPtr, OnCallMediaEventParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onCallMediaEvent(swigCPtr, OnCallMediaEventParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCreateMediaTransport(OnCreateMediaTransportParam prm) {
    if (SwigDerivedClassHasMethod("onCreateMediaTransport", swigMethodTypes22)) pjsua2PINVOKE.Call_onCreateMediaTransportSwigExplicitCall(swigCPtr, OnCreateMediaTransportParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onCreateMediaTransport(swigCPtr, OnCreateMediaTransportParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCreateMediaTransportSrtp(OnCreateMediaTransportSrtpParam prm) {
    if (SwigDerivedClassHasMethod("onCreateMediaTransportSrtp", swigMethodTypes23)) pjsua2PINVOKE.Call_onCreateMediaTransportSrtpSwigExplicitCall(swigCPtr, OnCreateMediaTransportSrtpParam.getCPtr(prm)); else pjsua2PINVOKE.Call_onCreateMediaTransportSrtp(swigCPtr, OnCreateMediaTransportSrtpParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("onCallState", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateCall_0(SwigDirectorMethodonCallState);
    if (SwigDerivedClassHasMethod("onCallTsxState", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateCall_1(SwigDirectorMethodonCallTsxState);
    if (SwigDerivedClassHasMethod("onCallMediaState", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateCall_2(SwigDirectorMethodonCallMediaState);
    if (SwigDerivedClassHasMethod("onCallSdpCreated", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateCall_3(SwigDirectorMethodonCallSdpCreated);
    if (SwigDerivedClassHasMethod("onStreamPreCreate", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateCall_4(SwigDirectorMethodonStreamPreCreate);
    if (SwigDerivedClassHasMethod("onStreamCreated", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateCall_5(SwigDirectorMethodonStreamCreated);
    if (SwigDerivedClassHasMethod("onStreamDestroyed", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateCall_6(SwigDirectorMethodonStreamDestroyed);
    if (SwigDerivedClassHasMethod("onDtmfDigit", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateCall_7(SwigDirectorMethodonDtmfDigit);
    if (SwigDerivedClassHasMethod("onDtmfEvent", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateCall_8(SwigDirectorMethodonDtmfEvent);
    if (SwigDerivedClassHasMethod("onCallTransferRequest", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateCall_9(SwigDirectorMethodonCallTransferRequest);
    if (SwigDerivedClassHasMethod("onCallTransferStatus", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateCall_10(SwigDirectorMethodonCallTransferStatus);
    if (SwigDerivedClassHasMethod("onCallReplaceRequest", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateCall_11(SwigDirectorMethodonCallReplaceRequest);
    if (SwigDerivedClassHasMethod("onCallReplaced", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateCall_12(SwigDirectorMethodonCallReplaced);
    if (SwigDerivedClassHasMethod("onCallRxOffer", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateCall_13(SwigDirectorMethodonCallRxOffer);
    if (SwigDerivedClassHasMethod("onCallRxReinvite", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateCall_14(SwigDirectorMethodonCallRxReinvite);
    if (SwigDerivedClassHasMethod("onCallTxOffer", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateCall_15(SwigDirectorMethodonCallTxOffer);
    if (SwigDerivedClassHasMethod("onInstantMessage", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateCall_16(SwigDirectorMethodonInstantMessage);
    if (SwigDerivedClassHasMethod("onInstantMessageStatus", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateCall_17(SwigDirectorMethodonInstantMessageStatus);
    if (SwigDerivedClassHasMethod("onTypingIndication", swigMethodTypes18))
      swigDelegate18 = new SwigDelegateCall_18(SwigDirectorMethodonTypingIndication);
    if (SwigDerivedClassHasMethod("onCallRedirected", swigMethodTypes19))
      swigDelegate19 = new SwigDelegateCall_19(SwigDirectorMethodonCallRedirected);
    if (SwigDerivedClassHasMethod("onCallMediaTransportState", swigMethodTypes20))
      swigDelegate20 = new SwigDelegateCall_20(SwigDirectorMethodonCallMediaTransportState);
    if (SwigDerivedClassHasMethod("onCallMediaEvent", swigMethodTypes21))
      swigDelegate21 = new SwigDelegateCall_21(SwigDirectorMethodonCallMediaEvent);
    if (SwigDerivedClassHasMethod("onCreateMediaTransport", swigMethodTypes22))
      swigDelegate22 = new SwigDelegateCall_22(SwigDirectorMethodonCreateMediaTransport);
    if (SwigDerivedClassHasMethod("onCreateMediaTransportSrtp", swigMethodTypes23))
      swigDelegate23 = new SwigDelegateCall_23(SwigDirectorMethodonCreateMediaTransportSrtp);
    pjsua2PINVOKE.Call_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17, swigDelegate18, swigDelegate19, swigDelegate20, swigDelegate21, swigDelegate22, swigDelegate23);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo[] methodInfos = this.GetType().GetMethods(
        global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance);
    foreach (global::System.Reflection.MethodInfo methodInfo in methodInfos) {
      if (methodInfo.DeclaringType == null)
        continue;

      if (methodInfo.Name != methodName)
        continue;

      var parameters = methodInfo.GetParameters();
      if (parameters.Length != methodTypes.Length)
        continue;

      bool parametersMatch = true;
      for (var i = 0; i < parameters.Length; i++) {
        if (parameters[i].ParameterType != methodTypes[i]) {
          parametersMatch = false;
          break;
        }
      }

      if (!parametersMatch)
        continue;

      if (methodInfo.IsVirtual && (methodInfo.DeclaringType.IsSubclassOf(typeof(Call))) &&
        methodInfo.DeclaringType != methodInfo.GetBaseDefinition().DeclaringType) {
        return true;
      }
    }

    return false;
  }

  private void SwigDirectorMethodonCallState(global::System.IntPtr prm) {
    onCallState(new OnCallStateParam(prm, false));
  }

  private void SwigDirectorMethodonCallTsxState(global::System.IntPtr prm) {
    onCallTsxState(new OnCallTsxStateParam(prm, false));
  }

  private void SwigDirectorMethodonCallMediaState(global::System.IntPtr prm) {
    onCallMediaState(new OnCallMediaStateParam(prm, false));
  }

  private void SwigDirectorMethodonCallSdpCreated(global::System.IntPtr prm) {
    onCallSdpCreated(new OnCallSdpCreatedParam(prm, false));
  }

  private void SwigDirectorMethodonStreamPreCreate(global::System.IntPtr prm) {
    onStreamPreCreate(new OnStreamPreCreateParam(prm, false));
  }

  private void SwigDirectorMethodonStreamCreated(global::System.IntPtr prm) {
    onStreamCreated(new OnStreamCreatedParam(prm, false));
  }

  private void SwigDirectorMethodonStreamDestroyed(global::System.IntPtr prm) {
    onStreamDestroyed(new OnStreamDestroyedParam(prm, false));
  }

  private void SwigDirectorMethodonDtmfDigit(global::System.IntPtr prm) {
    onDtmfDigit(new OnDtmfDigitParam(prm, false));
  }

  private void SwigDirectorMethodonDtmfEvent(global::System.IntPtr prm) {
    onDtmfEvent(new OnDtmfEventParam(prm, false));
  }

  private void SwigDirectorMethodonCallTransferRequest(global::System.IntPtr prm) {
    onCallTransferRequest(new OnCallTransferRequestParam(prm, false));
  }

  private void SwigDirectorMethodonCallTransferStatus(global::System.IntPtr prm) {
    onCallTransferStatus(new OnCallTransferStatusParam(prm, false));
  }

  private void SwigDirectorMethodonCallReplaceRequest(global::System.IntPtr prm) {
    onCallReplaceRequest(new OnCallReplaceRequestParam(prm, false));
  }

  private void SwigDirectorMethodonCallReplaced(global::System.IntPtr prm) {
    onCallReplaced(new OnCallReplacedParam(prm, false));
  }

  private void SwigDirectorMethodonCallRxOffer(global::System.IntPtr prm) {
    onCallRxOffer(new OnCallRxOfferParam(prm, false));
  }

  private void SwigDirectorMethodonCallRxReinvite(global::System.IntPtr prm) {
    onCallRxReinvite(new OnCallRxReinviteParam(prm, false));
  }

  private void SwigDirectorMethodonCallTxOffer(global::System.IntPtr prm) {
    onCallTxOffer(new OnCallTxOfferParam(prm, false));
  }

  private void SwigDirectorMethodonInstantMessage(global::System.IntPtr prm) {
    onInstantMessage(new OnInstantMessageParam(prm, false));
  }

  private void SwigDirectorMethodonInstantMessageStatus(global::System.IntPtr prm) {
    onInstantMessageStatus(new OnInstantMessageStatusParam(prm, false));
  }

  private void SwigDirectorMethodonTypingIndication(global::System.IntPtr prm) {
    onTypingIndication(new OnTypingIndicationParam(prm, false));
  }

  private int SwigDirectorMethodonCallRedirected(global::System.IntPtr prm) {
    return (int)onCallRedirected(new OnCallRedirectedParam(prm, false));
  }

  private void SwigDirectorMethodonCallMediaTransportState(global::System.IntPtr prm) {
    onCallMediaTransportState(new OnCallMediaTransportStateParam(prm, false));
  }

  private void SwigDirectorMethodonCallMediaEvent(global::System.IntPtr prm) {
    onCallMediaEvent(new OnCallMediaEventParam(prm, false));
  }

  private void SwigDirectorMethodonCreateMediaTransport(global::System.IntPtr prm) {
    onCreateMediaTransport(new OnCreateMediaTransportParam(prm, false));
  }

  private void SwigDirectorMethodonCreateMediaTransportSrtp(global::System.IntPtr prm) {
    onCreateMediaTransportSrtp(new OnCreateMediaTransportSrtpParam(prm, false));
  }

  public delegate void SwigDelegateCall_0(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_1(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_2(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_3(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_4(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_5(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_6(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_7(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_8(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_9(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_10(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_11(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_12(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_13(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_14(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_15(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_16(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_17(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_18(global::System.IntPtr prm);
  public delegate int SwigDelegateCall_19(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_20(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_21(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_22(global::System.IntPtr prm);
  public delegate void SwigDelegateCall_23(global::System.IntPtr prm);

  private SwigDelegateCall_0 swigDelegate0;
  private SwigDelegateCall_1 swigDelegate1;
  private SwigDelegateCall_2 swigDelegate2;
  private SwigDelegateCall_3 swigDelegate3;
  private SwigDelegateCall_4 swigDelegate4;
  private SwigDelegateCall_5 swigDelegate5;
  private SwigDelegateCall_6 swigDelegate6;
  private SwigDelegateCall_7 swigDelegate7;
  private SwigDelegateCall_8 swigDelegate8;
  private SwigDelegateCall_9 swigDelegate9;
  private SwigDelegateCall_10 swigDelegate10;
  private SwigDelegateCall_11 swigDelegate11;
  private SwigDelegateCall_12 swigDelegate12;
  private SwigDelegateCall_13 swigDelegate13;
  private SwigDelegateCall_14 swigDelegate14;
  private SwigDelegateCall_15 swigDelegate15;
  private SwigDelegateCall_16 swigDelegate16;
  private SwigDelegateCall_17 swigDelegate17;
  private SwigDelegateCall_18 swigDelegate18;
  private SwigDelegateCall_19 swigDelegate19;
  private SwigDelegateCall_20 swigDelegate20;
  private SwigDelegateCall_21 swigDelegate21;
  private SwigDelegateCall_22 swigDelegate22;
  private SwigDelegateCall_23 swigDelegate23;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(OnCallStateParam) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(OnCallTsxStateParam) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(OnCallMediaStateParam) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(OnCallSdpCreatedParam) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(OnStreamPreCreateParam) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] { typeof(OnStreamCreatedParam) };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] { typeof(OnStreamDestroyedParam) };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] { typeof(OnDtmfDigitParam) };
  private static global::System.Type[] swigMethodTypes8 = new global::System.Type[] { typeof(OnDtmfEventParam) };
  private static global::System.Type[] swigMethodTypes9 = new global::System.Type[] { typeof(OnCallTransferRequestParam) };
  private static global::System.Type[] swigMethodTypes10 = new global::System.Type[] { typeof(OnCallTransferStatusParam) };
  private static global::System.Type[] swigMethodTypes11 = new global::System.Type[] { typeof(OnCallReplaceRequestParam) };
  private static global::System.Type[] swigMethodTypes12 = new global::System.Type[] { typeof(OnCallReplacedParam) };
  private static global::System.Type[] swigMethodTypes13 = new global::System.Type[] { typeof(OnCallRxOfferParam) };
  private static global::System.Type[] swigMethodTypes14 = new global::System.Type[] { typeof(OnCallRxReinviteParam) };
  private static global::System.Type[] swigMethodTypes15 = new global::System.Type[] { typeof(OnCallTxOfferParam) };
  private static global::System.Type[] swigMethodTypes16 = new global::System.Type[] { typeof(OnInstantMessageParam) };
  private static global::System.Type[] swigMethodTypes17 = new global::System.Type[] { typeof(OnInstantMessageStatusParam) };
  private static global::System.Type[] swigMethodTypes18 = new global::System.Type[] { typeof(OnTypingIndicationParam) };
  private static global::System.Type[] swigMethodTypes19 = new global::System.Type[] { typeof(OnCallRedirectedParam) };
  private static global::System.Type[] swigMethodTypes20 = new global::System.Type[] { typeof(OnCallMediaTransportStateParam) };
  private static global::System.Type[] swigMethodTypes21 = new global::System.Type[] { typeof(OnCallMediaEventParam) };
  private static global::System.Type[] swigMethodTypes22 = new global::System.Type[] { typeof(OnCreateMediaTransportParam) };
  private static global::System.Type[] swigMethodTypes23 = new global::System.Type[] { typeof(OnCreateMediaTransportSrtpParam) };
}

}
