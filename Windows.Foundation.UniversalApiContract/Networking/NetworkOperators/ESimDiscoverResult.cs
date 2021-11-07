// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimDiscoverResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>A class representing the result of an eSIM profile discovery operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class ESimDiscoverResult : IESimDiscoverResult
  {
    /// <summary>Gets a collection of the discovery events related to the eSIM profile discovery operation.</summary>
    /// <returns>A collection of ESimDiscoverEvent objects representing the discovery events.</returns>
    public extern IVectorView<ESimDiscoverEvent> Events { [MethodImpl] get; }

    /// <summary>Gets the kind of the result object from the eSIM profile discovery operation. Also see Result.</summary>
    /// <returns>An ESimDiscoverResultKind object representing the kind of the result object.</returns>
    public extern ESimDiscoverResultKind Kind { [MethodImpl] get; }

    /// <summary>Gets the returned profile metadata, if applicable, depending on Kind.</summary>
    /// <returns>An ESimProfileMetadata object representing the returned profile metadata, if applicable.</returns>
    public extern ESimProfileMetadata ProfileMetadata { [MethodImpl] get; }

    /// <summary>Gets the result object from the eSIM profile discovery operation. This is a general operation result indicating success or failure. Also see Kind.</summary>
    /// <returns>An ESimOperationResult object representing the result object.</returns>
    public extern ESimOperationResult Result { [MethodImpl] get; }
  }
}
