// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.VisualStateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml
{
  /// <summary>Provides data for the CurrentStateChanging and CurrentStateChanged events.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class VisualStateChangedEventArgs : IVisualStateChangedEventArgs
  {
    /// <summary>Initializes a new instance of the VisualStateChangedEventArgs class.</summary>
    [MethodImpl]
    public extern VisualStateChangedEventArgs();

    /// <summary>Gets the state the Control is changing from or has changed from.</summary>
    /// <returns>The state the Control is changing from or has changed from.</returns>
    public extern VisualState OldState { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the state the Control is changing to or has changed to.</summary>
    /// <returns>The state the Control is changing to or has changed to.</returns>
    public extern VisualState NewState { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the Control that is changing states.</summary>
    /// <returns>The Control that is changing states.</returns>
    public extern Control Control { [MethodImpl] get; [MethodImpl] set; }
  }
}
