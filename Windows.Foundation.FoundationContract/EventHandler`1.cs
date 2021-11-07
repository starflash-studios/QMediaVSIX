// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.EventHandler`1
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Represents a method that handles general events.</summary>
  /// <typeparam name="T">
  /// </typeparam>
  /// <param name="sender">The event source.</param>
  /// <param name="args">The event data.</param>
  [Guid(2648818997, 27361, 4576, 132, 225, 24, 169, 5, 188, 197, 63)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public delegate void EventHandler<T>(object sender, T args);
}
