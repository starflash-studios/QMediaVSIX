// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.ConversationalAgentDetectorManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  /// <summary>Provides access to existing signal detector and configuration definitions of a digital assistant.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Static(typeof (IConversationalAgentDetectorManagerStatics), 655360, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class ConversationalAgentDetectorManager : 
    IConversationalAgentDetectorManager,
    IConversationalAgentDetectorManager2
  {
    /// <summary>Gets all ActivationSignalDetector objects available on the system that are associated with this manager and that correspond to the type of detector specified.</summary>
    /// <returns>When this method completes successfully, it returns a collection of activation signal detectors.</returns>
    [MethodImpl]
    public extern IVectorView<ActivationSignalDetector> GetAllActivationSignalDetectors();

    /// <summary>Asynchronously gets all ActivationSignalDetector objects available on the system that are associated with this manager and that correspond to the type of detector specified.</summary>
    /// <returns>When this method completes successfully, it returns a collection of activation signal detectors.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ActivationSignalDetector>> GetAllActivationSignalDetectorsAsync();

    /// <summary>Gets all ActivationSignalDetector objects available on the system that are associated with this manager.</summary>
    /// <param name="kind">A supported ActivationSignalDetector type.</param>
    /// <returns>When this method completes successfully, it returns an activation signal detector.</returns>
    [MethodImpl]
    public extern IVectorView<ActivationSignalDetector> GetActivationSignalDetectors(
      ActivationSignalDetectorKind kind);

    /// <summary>Asynchronously gets all ActivationSignalDetector objects available on the system that are associated with this manager.</summary>
    /// <param name="kind">A supported ActivationSignalDetector type.</param>
    /// <returns>When this method completes successfully, it returns an activation signal detector.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ActivationSignalDetector>> GetActivationSignalDetectorsAsync(
      ActivationSignalDetectorKind kind);

    [MethodImpl]
    public extern ActivationSignalDetector GetActivationSignalDetectorFromId(
      string detectorId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ActivationSignalDetector> GetActivationSignalDetectorFromIdAsync(
      string detectorId);

    /// <summary>Gets the global manager associated with all ActivationSignalDetector objects available on the system.</summary>
    /// <returns>The global manager associated with all ActivationSignalDetector objects available on the system.</returns>
    public static extern ConversationalAgentDetectorManager Default { [MethodImpl] get; }
  }
}
