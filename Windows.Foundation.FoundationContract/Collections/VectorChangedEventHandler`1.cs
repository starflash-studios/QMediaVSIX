// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.VectorChangedEventHandler`1
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  /// <summary>Represents the method that handles the changed event of an observable vector.</summary>
  /// <typeparam name="T">
  /// </typeparam>
  /// <param name="sender">The observable vector that changed.</param>
  /// <param name="@event">
  /// </param>
  [Guid(201660242, 40895, 19568, 170, 12, 14, 76, 130, 217, 167, 97)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public delegate void VectorChangedEventHandler<T>(
    IObservableVector<T> sender,
    IVectorChangedEventArgs @event);
}
