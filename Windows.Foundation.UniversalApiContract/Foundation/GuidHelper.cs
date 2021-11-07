// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.GuidHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>A class containing static helper methods for working with the **Guid** type.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGuidHelperStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  public static class GuidHelper
  {
    /// <summary>Creates a new, unique **Guid**.</summary>
    /// <returns>A new, unique **Guid**.</returns>
    [MethodImpl]
    public static extern Guid CreateNewGuid();

    /// <summary>Gets an empty, zeroed **Guid**.</summary>
    /// <returns>A **Guid** value that is empty, and zeroed.</returns>
    public static extern Guid Empty { [MethodImpl] get; }

    /// <summary>Compares two **Guid** values for equality.</summary>
    /// <param name="target">A **Guid** value to compare with the other argument.</param>
    /// <param name="value">A **Guid** value to compare with the other argument.</param>
    /// <returns>`true` if the two **Guid** values are equal, otherwise `false`.</returns>
    [MethodImpl]
    public static extern bool Equals(ref Guid target, ref Guid value);
  }
}
