// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IReferenceArray`1
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Enables arbitrary enumerations, structures, and delegate types to be used as an array of property values. You can't implement this interface, see Remarks.</summary>
  /// <typeparam name="T">
  /// </typeparam>
  [Guid(1640068871, 11621, 4576, 154, 232, 212, 133, 100, 1, 84, 114)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IReferenceArray<T> : IPropertyValue
  {
    /// <summary>Gets the type that is represented as an IPropertyValue array.</summary>
    /// <returns>The type.</returns>
    T[] Value { [MethodImpl] get; }
  }
}
