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

public class TlsConfig : PersistentObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal TlsConfig(global::System.IntPtr cPtr, bool cMemoryOwn) : base(pjsua2PINVOKE.TlsConfig_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TlsConfig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TlsConfig obj) {
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
          pjsua2PINVOKE.delete_TlsConfig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public string CaListFile {
    set {
      pjsua2PINVOKE.TlsConfig_CaListFile_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.TlsConfig_CaListFile_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string certFile {
    set {
      pjsua2PINVOKE.TlsConfig_certFile_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.TlsConfig_certFile_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string privKeyFile {
    set {
      pjsua2PINVOKE.TlsConfig_privKeyFile_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.TlsConfig_privKeyFile_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string password {
    set {
      pjsua2PINVOKE.TlsConfig_password_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.TlsConfig_password_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string CaBuf {
    set {
      pjsua2PINVOKE.TlsConfig_CaBuf_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.TlsConfig_CaBuf_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string certBuf {
    set {
      pjsua2PINVOKE.TlsConfig_certBuf_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.TlsConfig_certBuf_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string privKeyBuf {
    set {
      pjsua2PINVOKE.TlsConfig_privKeyBuf_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.TlsConfig_privKeyBuf_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public pjsip_ssl_method method {
    set {
      pjsua2PINVOKE.TlsConfig_method_set(swigCPtr, (int)value);
    } 
    get {
      pjsip_ssl_method ret = (pjsip_ssl_method)pjsua2PINVOKE.TlsConfig_method_get(swigCPtr);
      return ret;
    } 
  }

  public uint proto {
    set {
      pjsua2PINVOKE.TlsConfig_proto_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.TlsConfig_proto_get(swigCPtr);
      return ret;
    } 
  }

  public IntVector ciphers {
    set {
      pjsua2PINVOKE.TlsConfig_ciphers_set(swigCPtr, IntVector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.TlsConfig_ciphers_get(swigCPtr);
      IntVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new IntVector(cPtr, false);
      return ret;
    } 
  }

  public bool verifyServer {
    set {
      pjsua2PINVOKE.TlsConfig_verifyServer_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.TlsConfig_verifyServer_get(swigCPtr);
      return ret;
    } 
  }

  public bool verifyClient {
    set {
      pjsua2PINVOKE.TlsConfig_verifyClient_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.TlsConfig_verifyClient_get(swigCPtr);
      return ret;
    } 
  }

  public bool requireClientCert {
    set {
      pjsua2PINVOKE.TlsConfig_requireClientCert_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.TlsConfig_requireClientCert_get(swigCPtr);
      return ret;
    } 
  }

  public uint msecTimeout {
    set {
      pjsua2PINVOKE.TlsConfig_msecTimeout_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.TlsConfig_msecTimeout_get(swigCPtr);
      return ret;
    } 
  }

  public pj_qos_type qosType {
    set {
      pjsua2PINVOKE.TlsConfig_qosType_set(swigCPtr, (int)value);
    } 
    get {
      pj_qos_type ret = (pj_qos_type)pjsua2PINVOKE.TlsConfig_qosType_get(swigCPtr);
      return ret;
    } 
  }

  public pj_qos_params qosParams {
    set {
      pjsua2PINVOKE.TlsConfig_qosParams_set(swigCPtr, pj_qos_params.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.TlsConfig_qosParams_get(swigCPtr);
      pj_qos_params ret = (cPtr == global::System.IntPtr.Zero) ? null : new pj_qos_params(cPtr, false);
      return ret;
    } 
  }

  public bool qosIgnoreError {
    set {
      pjsua2PINVOKE.TlsConfig_qosIgnoreError_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.TlsConfig_qosIgnoreError_get(swigCPtr);
      return ret;
    } 
  }

  public bool enableRenegotiation {
    set {
      pjsua2PINVOKE.TlsConfig_enableRenegotiation_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.TlsConfig_enableRenegotiation_get(swigCPtr);
      return ret;
    } 
  }

  public TlsConfig() : this(pjsua2PINVOKE.new_TlsConfig(), true) {
  }

  public override void readObject(ContainerNode node) {
    pjsua2PINVOKE.TlsConfig_readObject(swigCPtr, ContainerNode.getCPtr(node));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public override void writeObject(ContainerNode node) {
    pjsua2PINVOKE.TlsConfig_writeObject(swigCPtr, ContainerNode.getCPtr(node));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

}

}
