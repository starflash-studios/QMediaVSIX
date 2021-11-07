// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DurationType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Declares whether a Duration has a special value of Automatic or Forever, or has valid information in its **TimeSpan** component.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DurationType
  {
    /// <summary>Has the Automatic special value.</summary>
    Automatic,
    /// <summary>Has valid information in the **TimeSpan** component.</summary>
    TimeSpan,
    /// <summary>Has the Forever special value.</summary>
    Forever,
  }
}
