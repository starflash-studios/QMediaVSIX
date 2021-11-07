// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.KnownUSimFilePaths
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Static class that provides known USIM file paths.</summary>
  [Static(typeof (IKnownUSimFilePathsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class KnownUSimFilePaths
  {
    /// <summary>Static property that gets the EFSPN path.</summary>
    /// <returns>The EFSPN path.</returns>
    public static extern IVectorView<uint> EFSpn { [MethodImpl] get; }

    /// <summary>Static property that gets the EFOPL path.</summary>
    /// <returns>The EFOPL path.</returns>
    public static extern IVectorView<uint> EFOpl { [MethodImpl] get; }

    /// <summary>Static property that gets the EFPNN path.</summary>
    /// <returns>The EFPNN path.</returns>
    public static extern IVectorView<uint> EFPnn { [MethodImpl] get; }

    /// <summary>Static property that gets the GID1 path.</summary>
    /// <returns>GID1 path.</returns>
    public static extern IVectorView<uint> Gid1 { [MethodImpl] get; }

    /// <summary>Static property that gets the GID2 path.</summary>
    /// <returns>The GID2 path.</returns>
    public static extern IVectorView<uint> Gid2 { [MethodImpl] get; }
  }
}
