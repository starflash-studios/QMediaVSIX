// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IObservableVector`1
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  /// <summary>Notifies listeners of changes to the vector.</summary>
  /// <typeparam name="T">
  /// </typeparam>
  [Guid(1494739795, 20660, 18957, 179, 9, 101, 134, 43, 63, 29, 188)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IObservableVector<T> : IVector<T>
  {
    /// <summary>Occurs when the vector changes.</summary>
    event VectorChangedEventHandler<T> VectorChanged;
  }
}
