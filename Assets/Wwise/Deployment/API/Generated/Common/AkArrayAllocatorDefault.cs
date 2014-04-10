#if ! (UNITY_DASHBOARD_WIDGET || UNITY_STANDALONE_LINUX || UNITY_WEBPLAYER || UNITY_WII || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY || UNITY_WP8) // Disable under unsupported platforms.
/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class AkArrayAllocatorDefault : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AkArrayAllocatorDefault(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(AkArrayAllocatorDefault obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~AkArrayAllocatorDefault() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkArrayAllocatorDefault(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static IntPtr Alloc(int in_poolId, uint in_uSize) { return AkSoundEnginePINVOKE.CSharp_AkArrayAllocatorDefault_Alloc(in_poolId, in_uSize); }

  public static void Free(int in_poolId, IntPtr in_pAddress) {
    AkSoundEnginePINVOKE.CSharp_AkArrayAllocatorDefault_Free(in_poolId, in_pAddress);

  }

  public AkArrayAllocatorDefault() : this(AkSoundEnginePINVOKE.CSharp_new_AkArrayAllocatorDefault(), true) {

  }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_STANDALONE_LINUX || UNITY_WEBPLAYER || UNITY_WII || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY || UNITY_WP8) // Disable under unsupported platforms.