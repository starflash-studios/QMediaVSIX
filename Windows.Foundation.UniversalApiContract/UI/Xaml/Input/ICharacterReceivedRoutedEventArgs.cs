// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ICharacterReceivedRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml.Input
{
  [WebHostHidden]
  [Guid(2018114946, 18660, 17485, 148, 25, 147, 171, 136, 146, 193, 7)]
  [ExclusiveTo(typeof (CharacterReceivedRoutedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ICharacterReceivedRoutedEventArgs
  {
    char Character { get; }

    CorePhysicalKeyStatus KeyStatus { get; }

    bool Handled { get; set; }
  }
}
