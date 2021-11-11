#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using Microsoft.VisualStudio.PlatformUI;
using Microsoft.VisualStudio.Shell;

#endregion

namespace QMediaVSIX.Environment;

// ReSharper disable once PartialTypeWithSinglePart
public static partial class Brushes {

  ///<inheritdoc cref="EnvironmentColors.AccentBorderBrushKey"/>
  public static ThemeResourceKey AccentBorder => EnvironmentColors.AccentBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AccentDarkBrushKey"/>
  public static ThemeResourceKey AccentDark => EnvironmentColors.AccentDarkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AccentLightBrushKey"/>
  public static ThemeResourceKey AccentLight => EnvironmentColors.AccentLightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AccentMediumBrushKey"/>
  public static ThemeResourceKey AccentMedium => EnvironmentColors.AccentMediumBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AccentPaleBrushKey"/>
  public static ThemeResourceKey AccentPale => EnvironmentColors.AccentPaleBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AccessKeyToolTipBrushKey"/>
  public static ThemeResourceKey AccessKeyToolTip => EnvironmentColors.AccessKeyToolTipBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AccessKeyToolTipTextBrushKey"/>
  public static ThemeResourceKey AccessKeyToolTipText => EnvironmentColors.AccessKeyToolTipTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AccessKeyToolTipBorderBrushKey"/>
  public static ThemeResourceKey AccessKeyToolTipBorder => EnvironmentColors.AccessKeyToolTipBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AccessKeyToolTipDisabledBrushKey"/>
  public static ThemeResourceKey AccessKeyToolTipDisabled => EnvironmentColors.AccessKeyToolTipDisabledBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AccessKeyToolTipDisabledTextBrushKey"/>
  public static ThemeResourceKey AccessKeyToolTipDisabledText => EnvironmentColors.AccessKeyToolTipDisabledTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AccessKeyToolTipDisabledBorderBrushKey"/>
  public static ThemeResourceKey AccessKeyToolTipDisabledBorder => EnvironmentColors.AccessKeyToolTipDisabledBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemActiveBorderBrushKey"/>
  public static ThemeResourceKey SystemActiveBorder => EnvironmentColors.SystemActiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemActiveCaptionBrushKey"/>
  public static ThemeResourceKey SystemActiveCaption => EnvironmentColors.SystemActiveCaptionBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemAppWorkspaceBrushKey"/>
  public static ThemeResourceKey SystemAppWorkspace => EnvironmentColors.SystemAppWorkspaceBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AutoHideResizeGripBrushKey"/>
  public static ThemeResourceKey AutoHideResizeGrip => EnvironmentColors.AutoHideResizeGripBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AutoHideResizeGripDisabledBrushKey"/>
  public static ThemeResourceKey AutoHideResizeGripDisabled => EnvironmentColors.AutoHideResizeGripDisabledBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AutoHideTabBackgroundBeginBrushKey"/>
  public static ThemeResourceKey AutoHideTabBackgroundBegin => EnvironmentColors.AutoHideTabBackgroundBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AutoHideTabBackgroundEndBrushKey"/>
  public static ThemeResourceKey AutoHideTabBackgroundEnd => EnvironmentColors.AutoHideTabBackgroundEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AutoHideTabBorderBrushKey"/>
  public static ThemeResourceKey AutoHideTabBorder => EnvironmentColors.AutoHideTabBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AutoHideTabMouseOverBackgroundBeginBrushKey"/>
  public static ThemeResourceKey AutoHideTabMouseOverBackgroundBegin => EnvironmentColors.AutoHideTabMouseOverBackgroundBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AutoHideTabMouseOverBackgroundEndBrushKey"/>
  public static ThemeResourceKey AutoHideTabMouseOverBackgroundEnd => EnvironmentColors.AutoHideTabMouseOverBackgroundEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AutoHideTabMouseOverBorderBrushKey"/>
  public static ThemeResourceKey AutoHideTabMouseOverBorder => EnvironmentColors.AutoHideTabMouseOverBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AutoHideTabMouseOverTextBrushKey"/>
  public static ThemeResourceKey AutoHideTabMouseOverText => EnvironmentColors.AutoHideTabMouseOverTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.AutoHideTabTextBrushKey"/>
  public static ThemeResourceKey AutoHideTabText => EnvironmentColors.AutoHideTabTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemBackgroundBrushKey"/>
  public static ThemeResourceKey SystemBackground => EnvironmentColors.SystemBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.BrandedUIBackgroundBrushKey"/>
  public static ThemeResourceKey BrandedUIBackground => EnvironmentColors.BrandedUIBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.BrandedUIBorderBrushKey"/>
  public static ThemeResourceKey BrandedUIBorder => EnvironmentColors.BrandedUIBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.BrandedUIFillBrushKey"/>
  public static ThemeResourceKey BrandedUIFill => EnvironmentColors.BrandedUIFillBrushKey;

  ///<inheritdoc cref="EnvironmentColors.BrandedUITextBrushKey"/>
  public static ThemeResourceKey BrandedUIText => EnvironmentColors.BrandedUITextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.BrandedUITitleBrushKey"/>
  public static ThemeResourceKey BrandedUITitle => EnvironmentColors.BrandedUITitleBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemButtonFaceBrushKey"/>
  public static ThemeResourceKey SystemButtonFace => EnvironmentColors.SystemButtonFaceBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemButtonHighlightBrushKey"/>
  public static ThemeResourceKey SystemButtonHighlight => EnvironmentColors.SystemButtonHighlightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemButtonShadowBrushKey"/>
  public static ThemeResourceKey SystemButtonShadow => EnvironmentColors.SystemButtonShadowBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemButtonTextBrushKey"/>
  public static ThemeResourceKey SystemButtonText => EnvironmentColors.SystemButtonTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemCaptionTextBrushKey"/>
  public static ThemeResourceKey SystemCaptionText => EnvironmentColors.SystemCaptionTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerClassCompartmentBrushKey"/>
  public static ThemeResourceKey ClassDesignerClassCompartment => EnvironmentColors.ClassDesignerClassCompartmentBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerClassHeaderBackgroundBrushKey"/>
  public static ThemeResourceKey ClassDesignerClassHeaderBackground => EnvironmentColors.ClassDesignerClassHeaderBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerCommentBorderBrushKey"/>
  public static ThemeResourceKey ClassDesignerCommentBorder => EnvironmentColors.ClassDesignerCommentBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerCommentShapeBackgroundBrushKey"/>
  public static ThemeResourceKey ClassDesignerCommentShapeBackground => EnvironmentColors.ClassDesignerCommentShapeBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerCommentTextBrushKey"/>
  public static ThemeResourceKey ClassDesignerCommentText => EnvironmentColors.ClassDesignerCommentTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerCompartmentSeparatorBrushKey"/>
  public static ThemeResourceKey ClassDesignerCompartmentSeparator => EnvironmentColors.ClassDesignerCompartmentSeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerConnectionRouteBorderBrushKey"/>
  public static ThemeResourceKey ClassDesignerConnectionRouteBorder => EnvironmentColors.ClassDesignerConnectionRouteBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerDefaultConnectionBrushKey"/>
  public static ThemeResourceKey ClassDesignerDefaultConnection => EnvironmentColors.ClassDesignerDefaultConnectionBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerDefaultShapeBackgroundBrushKey"/>
  public static ThemeResourceKey ClassDesignerDefaultShapeBackground => EnvironmentColors.ClassDesignerDefaultShapeBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerDefaultShapeBorderBrushKey"/>
  public static ThemeResourceKey ClassDesignerDefaultShapeBorder => EnvironmentColors.ClassDesignerDefaultShapeBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerDefaultShapeSubtitleBrushKey"/>
  public static ThemeResourceKey ClassDesignerDefaultShapeSubtitle => EnvironmentColors.ClassDesignerDefaultShapeSubtitleBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerDefaultShapeTextBrushKey"/>
  public static ThemeResourceKey ClassDesignerDefaultShapeText => EnvironmentColors.ClassDesignerDefaultShapeTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerDefaultShapeTitleBrushKey"/>
  public static ThemeResourceKey ClassDesignerDefaultShapeTitle => EnvironmentColors.ClassDesignerDefaultShapeTitleBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerDefaultShapeTitleBackgroundBrushKey"/>
  public static ThemeResourceKey ClassDesignerDefaultShapeTitleBackground => EnvironmentColors.ClassDesignerDefaultShapeTitleBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerDelegateCompartmentBrushKey"/>
  public static ThemeResourceKey ClassDesignerDelegateCompartment => EnvironmentColors.ClassDesignerDelegateCompartmentBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerDelegateHeaderBrushKey"/>
  public static ThemeResourceKey ClassDesignerDelegateHeader => EnvironmentColors.ClassDesignerDelegateHeaderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerDiagramBackgroundBrushKey"/>
  public static ThemeResourceKey ClassDesignerDiagramBackground => EnvironmentColors.ClassDesignerDiagramBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerEmphasisBorderBrushKey"/>
  public static ThemeResourceKey ClassDesignerEmphasisBorder => EnvironmentColors.ClassDesignerEmphasisBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerEnumHeaderBrushKey"/>
  public static ThemeResourceKey ClassDesignerEnumHeader => EnvironmentColors.ClassDesignerEnumHeaderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerFieldAssociationBrushKey"/>
  public static ThemeResourceKey ClassDesignerFieldAssociation => EnvironmentColors.ClassDesignerFieldAssociationBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerGradientEndBrushKey"/>
  public static ThemeResourceKey ClassDesignerGradientEnd => EnvironmentColors.ClassDesignerGradientEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerInheritanceBrushKey"/>
  public static ThemeResourceKey ClassDesignerInheritance => EnvironmentColors.ClassDesignerInheritanceBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerInterfaceCompartmentBrushKey"/>
  public static ThemeResourceKey ClassDesignerInterfaceCompartment => EnvironmentColors.ClassDesignerInterfaceCompartmentBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerInterfaceHeaderBrushKey"/>
  public static ThemeResourceKey ClassDesignerInterfaceHeader => EnvironmentColors.ClassDesignerInterfaceHeaderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerLassoBrushKey"/>
  public static ThemeResourceKey ClassDesignerLasso => EnvironmentColors.ClassDesignerLassoBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerLollipopBrushKey"/>
  public static ThemeResourceKey ClassDesignerLollipop => EnvironmentColors.ClassDesignerLollipopBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerPrimaryGrabHandleBrushKey"/>
  public static ThemeResourceKey ClassDesignerPrimaryGrabHandle => EnvironmentColors.ClassDesignerPrimaryGrabHandleBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerPrimaryLineGrabHandleBrushKey"/>
  public static ThemeResourceKey ClassDesignerPrimaryLineGrabHandle => EnvironmentColors.ClassDesignerPrimaryLineGrabHandleBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerPropertyAssociationBrushKey"/>
  public static ThemeResourceKey ClassDesignerPropertyAssociation => EnvironmentColors.ClassDesignerPropertyAssociationBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerReferencedAssemblyBorderBrushKey"/>
  public static ThemeResourceKey ClassDesignerReferencedAssemblyBorder => EnvironmentColors.ClassDesignerReferencedAssemblyBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerResizingShapeBorderBrushKey"/>
  public static ThemeResourceKey ClassDesignerResizingShapeBorder => EnvironmentColors.ClassDesignerResizingShapeBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerSecondaryLineGrabHandleBrushKey"/>
  public static ThemeResourceKey ClassDesignerSecondaryLineGrabHandle => EnvironmentColors.ClassDesignerSecondaryLineGrabHandleBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerShapeBorderBrushKey"/>
  public static ThemeResourceKey ClassDesignerShapeBorder => EnvironmentColors.ClassDesignerShapeBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerShapeShadowBrushKey"/>
  public static ThemeResourceKey ClassDesignerShapeShadow => EnvironmentColors.ClassDesignerShapeShadowBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerTempConnectionBrushKey"/>
  public static ThemeResourceKey ClassDesignerTempConnection => EnvironmentColors.ClassDesignerTempConnectionBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerTypedefBrushKey"/>
  public static ThemeResourceKey ClassDesignerTypedef => EnvironmentColors.ClassDesignerTypedefBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerTypedefHeaderBrushKey"/>
  public static ThemeResourceKey ClassDesignerTypedefHeader => EnvironmentColors.ClassDesignerTypedefHeaderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerUnresolvedTextBrushKey"/>
  public static ThemeResourceKey ClassDesignerUnresolvedText => EnvironmentColors.ClassDesignerUnresolvedTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerVBModuleCompartmentBrushKey"/>
  public static ThemeResourceKey ClassDesignerVBModuleCompartment => EnvironmentColors.ClassDesignerVBModuleCompartmentBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ClassDesignerVBModuleHeaderBrushKey"/>
  public static ThemeResourceKey ClassDesignerVBModuleHeader => EnvironmentColors.ClassDesignerVBModuleHeaderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxBackgroundBrushKey"/>
  public static ThemeResourceKey ComboBoxBackground => EnvironmentColors.ComboBoxBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxBorderBrushKey"/>
  public static ThemeResourceKey ComboBoxBorder => EnvironmentColors.ComboBoxBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxButtonMouseDownBackgroundBrushKey"/>
  public static ThemeResourceKey ComboBoxButtonMouseDownBackground => EnvironmentColors.ComboBoxButtonMouseDownBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxButtonMouseDownSeparatorBrushKey"/>
  public static ThemeResourceKey ComboBoxButtonMouseDownSeparator => EnvironmentColors.ComboBoxButtonMouseDownSeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxButtonMouseOverBackgroundBrushKey"/>
  public static ThemeResourceKey ComboBoxButtonMouseOverBackground => EnvironmentColors.ComboBoxButtonMouseOverBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxButtonMouseOverSeparatorBrushKey"/>
  public static ThemeResourceKey ComboBoxButtonMouseOverSeparator => EnvironmentColors.ComboBoxButtonMouseOverSeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxDisabledBackgroundBrushKey"/>
  public static ThemeResourceKey ComboBoxDisabledBackground => EnvironmentColors.ComboBoxDisabledBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxDisabledBorderBrushKey"/>
  public static ThemeResourceKey ComboBoxDisabledBorder => EnvironmentColors.ComboBoxDisabledBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxDisabledGlyphBrushKey"/>
  public static ThemeResourceKey ComboBoxDisabledGlyph => EnvironmentColors.ComboBoxDisabledGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxDisabledTextBrushKey"/>
  public static ThemeResourceKey ComboBoxDisabledText => EnvironmentColors.ComboBoxDisabledTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxFocusBoxBrushKey"/>
  public static ThemeResourceKey ComboBoxFocusBox => EnvironmentColors.ComboBoxFocusBoxBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxFocusedBackgroundBrushKey"/>
  public static ThemeResourceKey ComboBoxFocusedBackground => EnvironmentColors.ComboBoxFocusedBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxFocusedBorderBrushKey"/>
  public static ThemeResourceKey ComboBoxFocusedBorder => EnvironmentColors.ComboBoxFocusedBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxFocusedButtonBackgroundBrushKey"/>
  public static ThemeResourceKey ComboBoxFocusedButtonBackground => EnvironmentColors.ComboBoxFocusedButtonBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxFocusedButtonSeparatorBrushKey"/>
  public static ThemeResourceKey ComboBoxFocusedButtonSeparator => EnvironmentColors.ComboBoxFocusedButtonSeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxFocusedGlyphBrushKey"/>
  public static ThemeResourceKey ComboBoxFocusedGlyph => EnvironmentColors.ComboBoxFocusedGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxFocusedTextBrushKey"/>
  public static ThemeResourceKey ComboBoxFocusedText => EnvironmentColors.ComboBoxFocusedTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxGlyphBrushKey"/>
  public static ThemeResourceKey ComboBoxGlyph => EnvironmentColors.ComboBoxGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxItemMouseOverBackgroundBrushKey"/>
  public static ThemeResourceKey ComboBoxItemMouseOverBackground => EnvironmentColors.ComboBoxItemMouseOverBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxItemMouseOverBorderBrushKey"/>
  public static ThemeResourceKey ComboBoxItemMouseOverBorder => EnvironmentColors.ComboBoxItemMouseOverBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxItemMouseOverTextBrushKey"/>
  public static ThemeResourceKey ComboBoxItemMouseOverText => EnvironmentColors.ComboBoxItemMouseOverTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxItemTextBrushKey"/>
  public static ThemeResourceKey ComboBoxItemText => EnvironmentColors.ComboBoxItemTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxItemTextInactiveBrushKey"/>
  public static ThemeResourceKey ComboBoxItemTextInactive => EnvironmentColors.ComboBoxItemTextInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxMouseDownBackgroundBrushKey"/>
  public static ThemeResourceKey ComboBoxMouseDownBackground => EnvironmentColors.ComboBoxMouseDownBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxMouseDownBorderBrushKey"/>
  public static ThemeResourceKey ComboBoxMouseDownBorder => EnvironmentColors.ComboBoxMouseDownBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxMouseDownGlyphBrushKey"/>
  public static ThemeResourceKey ComboBoxMouseDownGlyph => EnvironmentColors.ComboBoxMouseDownGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxMouseDownTextBrushKey"/>
  public static ThemeResourceKey ComboBoxMouseDownText => EnvironmentColors.ComboBoxMouseDownTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxMouseOverBackgroundBeginBrushKey"/>
  public static ThemeResourceKey ComboBoxMouseOverBackgroundBegin => EnvironmentColors.ComboBoxMouseOverBackgroundBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxMouseOverBackgroundEndBrushKey"/>
  public static ThemeResourceKey ComboBoxMouseOverBackgroundEnd => EnvironmentColors.ComboBoxMouseOverBackgroundEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxMouseOverBackgroundMiddle1BrushKey"/>
  public static ThemeResourceKey ComboBoxMouseOverBackgroundMiddle1 => EnvironmentColors.ComboBoxMouseOverBackgroundMiddle1BrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxMouseOverBackgroundMiddle2BrushKey"/>
  public static ThemeResourceKey ComboBoxMouseOverBackgroundMiddle2 => EnvironmentColors.ComboBoxMouseOverBackgroundMiddle2BrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxMouseOverBorderBrushKey"/>
  public static ThemeResourceKey ComboBoxMouseOverBorder => EnvironmentColors.ComboBoxMouseOverBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxMouseOverGlyphBrushKey"/>
  public static ThemeResourceKey ComboBoxMouseOverGlyph => EnvironmentColors.ComboBoxMouseOverGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxMouseOverTextBrushKey"/>
  public static ThemeResourceKey ComboBoxMouseOverText => EnvironmentColors.ComboBoxMouseOverTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxPopupBackgroundBeginBrushKey"/>
  public static ThemeResourceKey ComboBoxPopupBackgroundBegin => EnvironmentColors.ComboBoxPopupBackgroundBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxPopupBackgroundEndBrushKey"/>
  public static ThemeResourceKey ComboBoxPopupBackgroundEnd => EnvironmentColors.ComboBoxPopupBackgroundEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxPopupBorderBrushKey"/>
  public static ThemeResourceKey ComboBoxPopupBorder => EnvironmentColors.ComboBoxPopupBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxSelectionBrushKey"/>
  public static ThemeResourceKey ComboBoxSelection => EnvironmentColors.ComboBoxSelectionBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ComboBoxTextBrushKey"/>
  public static ThemeResourceKey ComboBoxText => EnvironmentColors.ComboBoxTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarBorderBrushKey"/>
  public static ThemeResourceKey CommandBarBorder => EnvironmentColors.CommandBarBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarCheckBoxBrushKey"/>
  public static ThemeResourceKey CommandBarCheckBox => EnvironmentColors.CommandBarCheckBoxBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarCheckBoxDisabledBrushKey"/>
  public static ThemeResourceKey CommandBarCheckBoxDisabled => EnvironmentColors.CommandBarCheckBoxDisabledBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarCheckBoxMouseOverBrushKey"/>
  public static ThemeResourceKey CommandBarCheckBoxMouseOver => EnvironmentColors.CommandBarCheckBoxMouseOverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarDragHandleBrushKey"/>
  public static ThemeResourceKey CommandBarDragHandle => EnvironmentColors.CommandBarDragHandleBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarDragHandleShadowBrushKey"/>
  public static ThemeResourceKey CommandBarDragHandleShadow => EnvironmentColors.CommandBarDragHandleShadowBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarFrameControlHoverBrushKey"/>
  public static ThemeResourceKey CommandBarFrameControlHover => EnvironmentColors.CommandBarFrameControlHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarGradientBeginBrushKey"/>
  public static ThemeResourceKey CommandBarGradientBegin => EnvironmentColors.CommandBarGradientBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarGradientEndBrushKey"/>
  public static ThemeResourceKey CommandBarGradientEnd => EnvironmentColors.CommandBarGradientEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarGradientMiddleBrushKey"/>
  public static ThemeResourceKey CommandBarGradientMiddle => EnvironmentColors.CommandBarGradientMiddleBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarHoverBrushKey"/>
  public static ThemeResourceKey CommandBarHover => EnvironmentColors.CommandBarHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarHoverOverSelectedBrushKey"/>
  public static ThemeResourceKey CommandBarHoverOverSelected => EnvironmentColors.CommandBarHoverOverSelectedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarHoverOverSelectedIconBrushKey"/>
  public static ThemeResourceKey CommandBarHoverOverSelectedIcon => EnvironmentColors.CommandBarHoverOverSelectedIconBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarHoverOverSelectedIconBorderBrushKey"/>
  public static ThemeResourceKey CommandBarHoverOverSelectedIconBorder => EnvironmentColors.CommandBarHoverOverSelectedIconBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuBackgroundGradientBeginBrushKey"/>
  public static ThemeResourceKey CommandBarMenuBackgroundGradientBegin => EnvironmentColors.CommandBarMenuBackgroundGradientBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuBackgroundGradientEndBrushKey"/>
  public static ThemeResourceKey CommandBarMenuBackgroundGradientEnd => EnvironmentColors.CommandBarMenuBackgroundGradientEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuBorderBrushKey"/>
  public static ThemeResourceKey CommandBarMenuBorder => EnvironmentColors.CommandBarMenuBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuGlyphBrushKey"/>
  public static ThemeResourceKey CommandBarMenuGlyph => EnvironmentColors.CommandBarMenuGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuGroupHeaderLinkTextBrushKey"/>
  public static ThemeResourceKey CommandBarMenuGroupHeaderLinkText => EnvironmentColors.CommandBarMenuGroupHeaderLinkTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuGroupHeaderLinkTextHoverBrushKey"/>
  public static ThemeResourceKey CommandBarMenuGroupHeaderLinkTextHover => EnvironmentColors.CommandBarMenuGroupHeaderLinkTextHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuIconBackgroundBrushKey"/>
  public static ThemeResourceKey CommandBarMenuIconBackground => EnvironmentColors.CommandBarMenuIconBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuItemMouseOverBrushKey"/>
  public static ThemeResourceKey CommandBarMenuItemMouseOver => EnvironmentColors.CommandBarMenuItemMouseOverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuItemMouseOverTextBrushKey"/>
  public static ThemeResourceKey CommandBarMenuItemMouseOverText => EnvironmentColors.CommandBarMenuItemMouseOverTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuItemMouseOverBorderBrushKey"/>
  public static ThemeResourceKey CommandBarMenuItemMouseOverBorder => EnvironmentColors.CommandBarMenuItemMouseOverBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuLinkTextBrushKey"/>
  public static ThemeResourceKey CommandBarMenuLinkText => EnvironmentColors.CommandBarMenuLinkTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuLinkTextHoverBrushKey"/>
  public static ThemeResourceKey CommandBarMenuLinkTextHover => EnvironmentColors.CommandBarMenuLinkTextHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuMouseDownGlyphBrushKey"/>
  public static ThemeResourceKey CommandBarMenuMouseDownGlyph => EnvironmentColors.CommandBarMenuMouseDownGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuMouseOverGlyphBrushKey"/>
  public static ThemeResourceKey CommandBarMenuMouseOverGlyph => EnvironmentColors.CommandBarMenuMouseOverGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuMouseOverSeparatorBrushKey"/>
  public static ThemeResourceKey CommandBarMenuMouseOverSeparator => EnvironmentColors.CommandBarMenuMouseOverSeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuMouseOverSubmenuGlyphBrushKey"/>
  public static ThemeResourceKey CommandBarMenuMouseOverSubmenuGlyph => EnvironmentColors.CommandBarMenuMouseOverSubmenuGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuScrollGlyphBrushKey"/>
  public static ThemeResourceKey CommandBarMenuScrollGlyph => EnvironmentColors.CommandBarMenuScrollGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuSeparatorBrushKey"/>
  public static ThemeResourceKey CommandBarMenuSeparator => EnvironmentColors.CommandBarMenuSeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuSubmenuGlyphBrushKey"/>
  public static ThemeResourceKey CommandBarMenuSubmenuGlyph => EnvironmentColors.CommandBarMenuSubmenuGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuSubmenuGlyphHoverBrushKey"/>
  public static ThemeResourceKey CommandBarMenuSubmenuGlyphHover => EnvironmentColors.CommandBarMenuSubmenuGlyphHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuWatermarkLinkTextBrushKey"/>
  public static ThemeResourceKey CommandBarMenuWatermarkLinkText => EnvironmentColors.CommandBarMenuWatermarkLinkTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuWatermarkLinkTextHoverBrushKey"/>
  public static ThemeResourceKey CommandBarMenuWatermarkLinkTextHover => EnvironmentColors.CommandBarMenuWatermarkLinkTextHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuWatermarkTextBrushKey"/>
  public static ThemeResourceKey CommandBarMenuWatermarkText => EnvironmentColors.CommandBarMenuWatermarkTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMenuWatermarkTextHoverBrushKey"/>
  public static ThemeResourceKey CommandBarMenuWatermarkTextHover => EnvironmentColors.CommandBarMenuWatermarkTextHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMouseDownBackgroundBeginBrushKey"/>
  public static ThemeResourceKey CommandBarMouseDownBackgroundBegin => EnvironmentColors.CommandBarMouseDownBackgroundBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMouseDownBackgroundEndBrushKey"/>
  public static ThemeResourceKey CommandBarMouseDownBackgroundEnd => EnvironmentColors.CommandBarMouseDownBackgroundEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMouseDownBackgroundMiddleBrushKey"/>
  public static ThemeResourceKey CommandBarMouseDownBackgroundMiddle => EnvironmentColors.CommandBarMouseDownBackgroundMiddleBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMouseDownBorderBrushKey"/>
  public static ThemeResourceKey CommandBarMouseDownBorder => EnvironmentColors.CommandBarMouseDownBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMouseOverBackgroundBeginBrushKey"/>
  public static ThemeResourceKey CommandBarMouseOverBackgroundBegin => EnvironmentColors.CommandBarMouseOverBackgroundBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMouseOverBackgroundEndBrushKey"/>
  public static ThemeResourceKey CommandBarMouseOverBackgroundEnd => EnvironmentColors.CommandBarMouseOverBackgroundEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMouseOverBackgroundMiddle1BrushKey"/>
  public static ThemeResourceKey CommandBarMouseOverBackgroundMiddle1 => EnvironmentColors.CommandBarMouseOverBackgroundMiddle1BrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMouseOverBackgroundMiddle2BrushKey"/>
  public static ThemeResourceKey CommandBarMouseOverBackgroundMiddle2 => EnvironmentColors.CommandBarMouseOverBackgroundMiddle2BrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarMouseOverUnfocusedBrushKey"/>
  public static ThemeResourceKey CommandBarMouseOverUnfocused => EnvironmentColors.CommandBarMouseOverUnfocusedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarOptionsBackgroundBrushKey"/>
  public static ThemeResourceKey CommandBarOptionsBackground => EnvironmentColors.CommandBarOptionsBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarOptionsGlyphBrushKey"/>
  public static ThemeResourceKey CommandBarOptionsGlyph => EnvironmentColors.CommandBarOptionsGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarOptionsMouseDownBackgroundBeginBrushKey"/>
  public static ThemeResourceKey CommandBarOptionsMouseDownBackgroundBegin => EnvironmentColors.CommandBarOptionsMouseDownBackgroundBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarOptionsMouseDownBackgroundEndBrushKey"/>
  public static ThemeResourceKey CommandBarOptionsMouseDownBackgroundEnd => EnvironmentColors.CommandBarOptionsMouseDownBackgroundEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarOptionsMouseDownBackgroundMiddleBrushKey"/>
  public static ThemeResourceKey CommandBarOptionsMouseDownBackgroundMiddle => EnvironmentColors.CommandBarOptionsMouseDownBackgroundMiddleBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarOptionsMouseDownGlyphBrushKey"/>
  public static ThemeResourceKey CommandBarOptionsMouseDownGlyph => EnvironmentColors.CommandBarOptionsMouseDownGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarOptionsMouseOverBackgroundBeginBrushKey"/>
  public static ThemeResourceKey CommandBarOptionsMouseOverBackgroundBegin => EnvironmentColors.CommandBarOptionsMouseOverBackgroundBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarOptionsMouseOverBackgroundEndBrushKey"/>
  public static ThemeResourceKey CommandBarOptionsMouseOverBackgroundEnd => EnvironmentColors.CommandBarOptionsMouseOverBackgroundEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarOptionsMouseOverBackgroundMiddle1BrushKey"/>
  public static ThemeResourceKey CommandBarOptionsMouseOverBackgroundMiddle1 => EnvironmentColors.CommandBarOptionsMouseOverBackgroundMiddle1BrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarOptionsMouseOverBackgroundMiddle2BrushKey"/>
  public static ThemeResourceKey CommandBarOptionsMouseOverBackgroundMiddle2 => EnvironmentColors.CommandBarOptionsMouseOverBackgroundMiddle2BrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarOptionsMouseOverGlyphBrushKey"/>
  public static ThemeResourceKey CommandBarOptionsMouseOverGlyph => EnvironmentColors.CommandBarOptionsMouseOverGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarSelectedBrushKey"/>
  public static ThemeResourceKey CommandBarSelected => EnvironmentColors.CommandBarSelectedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarSelectedBorderBrushKey"/>
  public static ThemeResourceKey CommandBarSelectedBorder => EnvironmentColors.CommandBarSelectedBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarSelectedIconBrushKey"/>
  public static ThemeResourceKey CommandBarSelectedIcon => EnvironmentColors.CommandBarSelectedIconBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarSelectedIconBorderBrushKey"/>
  public static ThemeResourceKey CommandBarSelectedIconBorder => EnvironmentColors.CommandBarSelectedIconBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarSelectedIconDisabledBrushKey"/>
  public static ThemeResourceKey CommandBarSelectedIconDisabled => EnvironmentColors.CommandBarSelectedIconDisabledBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarSelectedIconDisabledBorderBrushKey"/>
  public static ThemeResourceKey CommandBarSelectedIconDisabledBorder => EnvironmentColors.CommandBarSelectedIconDisabledBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarShadowBrushKey"/>
  public static ThemeResourceKey CommandBarShadow => EnvironmentColors.CommandBarShadowBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarSplitButtonGlyphBrushKey"/>
  public static ThemeResourceKey CommandBarSplitButtonGlyph => EnvironmentColors.CommandBarSplitButtonGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarSplitButtonMouseDownGlyphBrushKey"/>
  public static ThemeResourceKey CommandBarSplitButtonMouseDownGlyph => EnvironmentColors.CommandBarSplitButtonMouseDownGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarSplitButtonMouseOverGlyphBrushKey"/>
  public static ThemeResourceKey CommandBarSplitButtonMouseOverGlyph => EnvironmentColors.CommandBarSplitButtonMouseOverGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarSplitButtonSeparatorBrushKey"/>
  public static ThemeResourceKey CommandBarSplitButtonSeparator => EnvironmentColors.CommandBarSplitButtonSeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarTextActiveBrushKey"/>
  public static ThemeResourceKey CommandBarTextActive => EnvironmentColors.CommandBarTextActiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarTextHoverBrushKey"/>
  public static ThemeResourceKey CommandBarTextHover => EnvironmentColors.CommandBarTextHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarTextHoverOverSelectedBrushKey"/>
  public static ThemeResourceKey CommandBarTextHoverOverSelected => EnvironmentColors.CommandBarTextHoverOverSelectedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarTextInactiveBrushKey"/>
  public static ThemeResourceKey CommandBarTextInactive => EnvironmentColors.CommandBarTextInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarTextMouseDownBrushKey"/>
  public static ThemeResourceKey CommandBarTextMouseDown => EnvironmentColors.CommandBarTextMouseDownBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarTextSelectedBrushKey"/>
  public static ThemeResourceKey CommandBarTextSelected => EnvironmentColors.CommandBarTextSelectedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarToolBarBorderBrushKey"/>
  public static ThemeResourceKey CommandBarToolBarBorder => EnvironmentColors.CommandBarToolBarBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarToolBarSeparatorBrushKey"/>
  public static ThemeResourceKey CommandBarToolBarSeparator => EnvironmentColors.CommandBarToolBarSeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarToolBarSeparatorHighlightBrushKey"/>
  public static ThemeResourceKey CommandBarToolBarSeparatorHighlight => EnvironmentColors.CommandBarToolBarSeparatorHighlightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandShelfBackgroundGradientBeginBrushKey"/>
  public static ThemeResourceKey CommandShelfBackgroundGradientBegin => EnvironmentColors.CommandShelfBackgroundGradientBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandShelfBackgroundGradientEndBrushKey"/>
  public static ThemeResourceKey CommandShelfBackgroundGradientEnd => EnvironmentColors.CommandShelfBackgroundGradientEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandShelfBackgroundGradientMiddleBrushKey"/>
  public static ThemeResourceKey CommandShelfBackgroundGradientMiddle => EnvironmentColors.CommandShelfBackgroundGradientMiddleBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandShelfHighlightGradientBeginBrushKey"/>
  public static ThemeResourceKey CommandShelfHighlightGradientBegin => EnvironmentColors.CommandShelfHighlightGradientBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandShelfHighlightGradientEndBrushKey"/>
  public static ThemeResourceKey CommandShelfHighlightGradientEnd => EnvironmentColors.CommandShelfHighlightGradientEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandShelfHighlightGradientMiddleBrushKey"/>
  public static ThemeResourceKey CommandShelfHighlightGradientMiddle => EnvironmentColors.CommandShelfHighlightGradientMiddleBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CompletionBorderBrushKey"/>
  public static ThemeResourceKey CompletionBorder => EnvironmentColors.CompletionBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ControlEditHintTextBrushKey"/>
  public static ThemeResourceKey ControlEditHintText => EnvironmentColors.ControlEditHintTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ControlEditRequiredBackgroundBrushKey"/>
  public static ThemeResourceKey ControlEditRequiredBackground => EnvironmentColors.ControlEditRequiredBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ControlEditRequiredHintTextBrushKey"/>
  public static ThemeResourceKey ControlEditRequiredHintText => EnvironmentColors.ControlEditRequiredHintTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ControlLinkTextBrushKey"/>
  public static ThemeResourceKey ControlLinkText => EnvironmentColors.ControlLinkTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ControlLinkTextHoverBrushKey"/>
  public static ThemeResourceKey ControlLinkTextHover => EnvironmentColors.ControlLinkTextHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ControlLinkTextPressedBrushKey"/>
  public static ThemeResourceKey ControlLinkTextPressed => EnvironmentColors.ControlLinkTextPressedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ControlOutlineBrushKey"/>
  public static ThemeResourceKey ControlOutline => EnvironmentColors.ControlOutlineBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DarkBrushKey"/>
  public static ThemeResourceKey Dark => EnvironmentColors.DarkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DebuggerDataTipActiveBackgroundBrushKey"/>
  public static ThemeResourceKey DebuggerDataTipActiveBackground => EnvironmentColors.DebuggerDataTipActiveBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DebuggerDataTipActiveBorderBrushKey"/>
  public static ThemeResourceKey DebuggerDataTipActiveBorder => EnvironmentColors.DebuggerDataTipActiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DebuggerDataTipActiveHighlightBrushKey"/>
  public static ThemeResourceKey DebuggerDataTipActiveHighlight => EnvironmentColors.DebuggerDataTipActiveHighlightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DebuggerDataTipActiveHighlightTextBrushKey"/>
  public static ThemeResourceKey DebuggerDataTipActiveHighlightText => EnvironmentColors.DebuggerDataTipActiveHighlightTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DebuggerDataTipActiveSeparatorBrushKey"/>
  public static ThemeResourceKey DebuggerDataTipActiveSeparator => EnvironmentColors.DebuggerDataTipActiveSeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DebuggerDataTipActiveTextBrushKey"/>
  public static ThemeResourceKey DebuggerDataTipActiveText => EnvironmentColors.DebuggerDataTipActiveTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DebuggerDataTipInactiveBackgroundBrushKey"/>
  public static ThemeResourceKey DebuggerDataTipInactiveBackground => EnvironmentColors.DebuggerDataTipInactiveBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DebuggerDataTipInactiveBorderBrushKey"/>
  public static ThemeResourceKey DebuggerDataTipInactiveBorder => EnvironmentColors.DebuggerDataTipInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DebuggerDataTipInactiveHighlightBrushKey"/>
  public static ThemeResourceKey DebuggerDataTipInactiveHighlight => EnvironmentColors.DebuggerDataTipInactiveHighlightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DebuggerDataTipInactiveHighlightTextBrushKey"/>
  public static ThemeResourceKey DebuggerDataTipInactiveHighlightText => EnvironmentColors.DebuggerDataTipInactiveHighlightTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DebuggerDataTipInactiveSeparatorBrushKey"/>
  public static ThemeResourceKey DebuggerDataTipInactiveSeparator => EnvironmentColors.DebuggerDataTipInactiveSeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DebuggerDataTipInactiveTextBrushKey"/>
  public static ThemeResourceKey DebuggerDataTipInactiveText => EnvironmentColors.DebuggerDataTipInactiveTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DesignerBackgroundBrushKey"/>
  public static ThemeResourceKey DesignerBackground => EnvironmentColors.DesignerBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DesignerSelectionDotsBrushKey"/>
  public static ThemeResourceKey DesignerSelectionDots => EnvironmentColors.DesignerSelectionDotsBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DesignerTrayBrushKey"/>
  public static ThemeResourceKey DesignerTray => EnvironmentColors.DesignerTrayBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DesignerWatermarkBrushKey"/>
  public static ThemeResourceKey DesignerWatermark => EnvironmentColors.DesignerWatermarkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DiagReportBackgroundBrushKey"/>
  public static ThemeResourceKey DiagReportBackground => EnvironmentColors.DiagReportBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DiagReportLinkTextBrushKey"/>
  public static ThemeResourceKey DiagReportLinkText => EnvironmentColors.DiagReportLinkTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DiagReportLinkTextHoverBrushKey"/>
  public static ThemeResourceKey DiagReportLinkTextHover => EnvironmentColors.DiagReportLinkTextHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DiagReportSecondaryPageHeaderBrushKey"/>
  public static ThemeResourceKey DiagReportSecondaryPageHeader => EnvironmentColors.DiagReportSecondaryPageHeaderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DiagReportSecondaryPageSubtitleBrushKey"/>
  public static ThemeResourceKey DiagReportSecondaryPageSubtitle => EnvironmentColors.DiagReportSecondaryPageSubtitleBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DiagReportSecondaryPageTitleBrushKey"/>
  public static ThemeResourceKey DiagReportSecondaryPageTitle => EnvironmentColors.DiagReportSecondaryPageTitleBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DiagReportSummaryPageHeaderBrushKey"/>
  public static ThemeResourceKey DiagReportSummaryPageHeader => EnvironmentColors.DiagReportSummaryPageHeaderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DiagReportSummaryPageSubtitleBrushKey"/>
  public static ThemeResourceKey DiagReportSummaryPageSubtitle => EnvironmentColors.DiagReportSummaryPageSubtitleBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DiagReportSummaryPageTitleBrushKey"/>
  public static ThemeResourceKey DiagReportSummaryPageTitle => EnvironmentColors.DiagReportSummaryPageTitleBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DiagReportTextBrushKey"/>
  public static ThemeResourceKey DiagReportText => EnvironmentColors.DiagReportTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DialogBrushKey"/>
  public static ThemeResourceKey Dialog => EnvironmentColors.DialogBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DialogTextBrushKey"/>
  public static ThemeResourceKey DialogText => EnvironmentColors.DialogTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DockTargetBackgroundBrushKey"/>
  public static ThemeResourceKey DockTargetBackground => EnvironmentColors.DockTargetBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DockTargetBorderBrushKey"/>
  public static ThemeResourceKey DockTargetBorder => EnvironmentColors.DockTargetBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DockTargetButtonBackgroundBeginBrushKey"/>
  public static ThemeResourceKey DockTargetButtonBackgroundBegin => EnvironmentColors.DockTargetButtonBackgroundBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DockTargetButtonBackgroundEndBrushKey"/>
  public static ThemeResourceKey DockTargetButtonBackgroundEnd => EnvironmentColors.DockTargetButtonBackgroundEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DockTargetButtonBorderBrushKey"/>
  public static ThemeResourceKey DockTargetButtonBorder => EnvironmentColors.DockTargetButtonBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DockTargetGlyphArrowBrushKey"/>
  public static ThemeResourceKey DockTargetGlyphArrow => EnvironmentColors.DockTargetGlyphArrowBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DockTargetGlyphBackgroundBeginBrushKey"/>
  public static ThemeResourceKey DockTargetGlyphBackgroundBegin => EnvironmentColors.DockTargetGlyphBackgroundBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DockTargetGlyphBackgroundEndBrushKey"/>
  public static ThemeResourceKey DockTargetGlyphBackgroundEnd => EnvironmentColors.DockTargetGlyphBackgroundEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DockTargetGlyphBorderBrushKey"/>
  public static ThemeResourceKey DockTargetGlyphBorder => EnvironmentColors.DockTargetGlyphBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DocWellOverflowButtonBackgroundBrushKey"/>
  public static ThemeResourceKey DocWellOverflowButtonBackground => EnvironmentColors.DocWellOverflowButtonBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DocWellOverflowButtonGlyphBrushKey"/>
  public static ThemeResourceKey DocWellOverflowButtonGlyph => EnvironmentColors.DocWellOverflowButtonGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DocWellOverflowButtonMouseDownBackgroundBrushKey"/>
  public static ThemeResourceKey DocWellOverflowButtonMouseDownBackground => EnvironmentColors.DocWellOverflowButtonMouseDownBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DocWellOverflowButtonMouseDownBorderBrushKey"/>
  public static ThemeResourceKey DocWellOverflowButtonMouseDownBorder => EnvironmentColors.DocWellOverflowButtonMouseDownBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DocWellOverflowButtonMouseDownGlyphBrushKey"/>
  public static ThemeResourceKey DocWellOverflowButtonMouseDownGlyph => EnvironmentColors.DocWellOverflowButtonMouseDownGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DocWellOverflowButtonMouseOverBackgroundBrushKey"/>
  public static ThemeResourceKey DocWellOverflowButtonMouseOverBackground => EnvironmentColors.DocWellOverflowButtonMouseOverBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DocWellOverflowButtonMouseOverBorderBrushKey"/>
  public static ThemeResourceKey DocWellOverflowButtonMouseOverBorder => EnvironmentColors.DocWellOverflowButtonMouseOverBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DocWellOverflowButtonMouseOverGlyphBrushKey"/>
  public static ThemeResourceKey DocWellOverflowButtonMouseOverGlyph => EnvironmentColors.DocWellOverflowButtonMouseOverGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownBackgroundBrushKey"/>
  public static ThemeResourceKey DropDownBackground => EnvironmentColors.DropDownBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownBorderBrushKey"/>
  public static ThemeResourceKey DropDownBorder => EnvironmentColors.DropDownBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownButtonMouseDownBackgroundBrushKey"/>
  public static ThemeResourceKey DropDownButtonMouseDownBackground => EnvironmentColors.DropDownButtonMouseDownBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownButtonMouseDownSeparatorBrushKey"/>
  public static ThemeResourceKey DropDownButtonMouseDownSeparator => EnvironmentColors.DropDownButtonMouseDownSeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownButtonMouseOverBackgroundBrushKey"/>
  public static ThemeResourceKey DropDownButtonMouseOverBackground => EnvironmentColors.DropDownButtonMouseOverBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownButtonMouseOverSeparatorBrushKey"/>
  public static ThemeResourceKey DropDownButtonMouseOverSeparator => EnvironmentColors.DropDownButtonMouseOverSeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownDisabledBackgroundBrushKey"/>
  public static ThemeResourceKey DropDownDisabledBackground => EnvironmentColors.DropDownDisabledBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownDisabledBorderBrushKey"/>
  public static ThemeResourceKey DropDownDisabledBorder => EnvironmentColors.DropDownDisabledBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownDisabledGlyphBrushKey"/>
  public static ThemeResourceKey DropDownDisabledGlyph => EnvironmentColors.DropDownDisabledGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownDisabledTextBrushKey"/>
  public static ThemeResourceKey DropDownDisabledText => EnvironmentColors.DropDownDisabledTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownGlyphBrushKey"/>
  public static ThemeResourceKey DropDownGlyph => EnvironmentColors.DropDownGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownMouseDownBackgroundBrushKey"/>
  public static ThemeResourceKey DropDownMouseDownBackground => EnvironmentColors.DropDownMouseDownBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownMouseDownBorderBrushKey"/>
  public static ThemeResourceKey DropDownMouseDownBorder => EnvironmentColors.DropDownMouseDownBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownMouseDownGlyphBrushKey"/>
  public static ThemeResourceKey DropDownMouseDownGlyph => EnvironmentColors.DropDownMouseDownGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownMouseDownTextBrushKey"/>
  public static ThemeResourceKey DropDownMouseDownText => EnvironmentColors.DropDownMouseDownTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownMouseOverBackgroundBeginBrushKey"/>
  public static ThemeResourceKey DropDownMouseOverBackgroundBegin => EnvironmentColors.DropDownMouseOverBackgroundBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownMouseOverBackgroundEndBrushKey"/>
  public static ThemeResourceKey DropDownMouseOverBackgroundEnd => EnvironmentColors.DropDownMouseOverBackgroundEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownMouseOverBackgroundMiddle1BrushKey"/>
  public static ThemeResourceKey DropDownMouseOverBackgroundMiddle1 => EnvironmentColors.DropDownMouseOverBackgroundMiddle1BrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownMouseOverBackgroundMiddle2BrushKey"/>
  public static ThemeResourceKey DropDownMouseOverBackgroundMiddle2 => EnvironmentColors.DropDownMouseOverBackgroundMiddle2BrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownMouseOverBorderBrushKey"/>
  public static ThemeResourceKey DropDownMouseOverBorder => EnvironmentColors.DropDownMouseOverBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownMouseOverGlyphBrushKey"/>
  public static ThemeResourceKey DropDownMouseOverGlyph => EnvironmentColors.DropDownMouseOverGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownMouseOverTextBrushKey"/>
  public static ThemeResourceKey DropDownMouseOverText => EnvironmentColors.DropDownMouseOverTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownPopupBackgroundBeginBrushKey"/>
  public static ThemeResourceKey DropDownPopupBackgroundBegin => EnvironmentColors.DropDownPopupBackgroundBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownPopupBackgroundEndBrushKey"/>
  public static ThemeResourceKey DropDownPopupBackgroundEnd => EnvironmentColors.DropDownPopupBackgroundEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownPopupBorderBrushKey"/>
  public static ThemeResourceKey DropDownPopupBorder => EnvironmentColors.DropDownPopupBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropDownTextBrushKey"/>
  public static ThemeResourceKey DropDownText => EnvironmentColors.DropDownTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.DropShadowBackgroundBrushKey"/>
  public static ThemeResourceKey DropShadowBackground => EnvironmentColors.DropShadowBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.EditorAdditionalContentBorderBrushKey"/>
  public static ThemeResourceKey EditorAdditionalContentBorder => EnvironmentColors.EditorAdditionalContentBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.EditorExpansionBorderBrushKey"/>
  public static ThemeResourceKey EditorExpansionBorder => EnvironmentColors.EditorExpansionBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.EditorExpansionFillBrushKey"/>
  public static ThemeResourceKey EditorExpansionFill => EnvironmentColors.EditorExpansionFillBrushKey;

  ///<inheritdoc cref="EnvironmentColors.EditorExpansionLinkBrushKey"/>
  public static ThemeResourceKey EditorExpansionLink => EnvironmentColors.EditorExpansionLinkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.EditorExpansionTextBrushKey"/>
  public static ThemeResourceKey EditorExpansionText => EnvironmentColors.EditorExpansionTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.EnvironmentBackgroundBrushKey"/>
  public static ThemeResourceKey EnvironmentBackground => EnvironmentColors.EnvironmentBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.EnvironmentBackgroundGradientBeginBrushKey"/>
  public static ThemeResourceKey EnvironmentBackgroundGradientBegin => EnvironmentColors.EnvironmentBackgroundGradientBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.EnvironmentBackgroundGradientEndBrushKey"/>
  public static ThemeResourceKey EnvironmentBackgroundGradientEnd => EnvironmentColors.EnvironmentBackgroundGradientEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.EnvironmentBackgroundGradientMiddle1BrushKey"/>
  public static ThemeResourceKey EnvironmentBackgroundGradientMiddle1 => EnvironmentColors.EnvironmentBackgroundGradientMiddle1BrushKey;

  ///<inheritdoc cref="EnvironmentColors.EnvironmentBackgroundGradientMiddle2BrushKey"/>
  public static ThemeResourceKey EnvironmentBackgroundGradientMiddle2 => EnvironmentColors.EnvironmentBackgroundGradientMiddle2BrushKey;

  ///<inheritdoc cref="EnvironmentColors.EnvironmentBackgroundTexture1BrushKey"/>
  public static ThemeResourceKey EnvironmentBackgroundTexture1 => EnvironmentColors.EnvironmentBackgroundTexture1BrushKey;

  ///<inheritdoc cref="EnvironmentColors.EnvironmentBackgroundTexture2BrushKey"/>
  public static ThemeResourceKey EnvironmentBackgroundTexture2 => EnvironmentColors.EnvironmentBackgroundTexture2BrushKey;

  ///<inheritdoc cref="EnvironmentColors.ExtensionManagerStarHighlight1BrushKey"/>
  public static ThemeResourceKey ExtensionManagerStarHighlight1 => EnvironmentColors.ExtensionManagerStarHighlight1BrushKey;

  ///<inheritdoc cref="EnvironmentColors.ExtensionManagerStarHighlight2BrushKey"/>
  public static ThemeResourceKey ExtensionManagerStarHighlight2 => EnvironmentColors.ExtensionManagerStarHighlight2BrushKey;

  ///<inheritdoc cref="EnvironmentColors.ExtensionManagerStarInactive1BrushKey"/>
  public static ThemeResourceKey ExtensionManagerStarInactive1 => EnvironmentColors.ExtensionManagerStarInactive1BrushKey;

  ///<inheritdoc cref="EnvironmentColors.ExtensionManagerStarInactive2BrushKey"/>
  public static ThemeResourceKey ExtensionManagerStarInactive2 => EnvironmentColors.ExtensionManagerStarInactive2BrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabActiveGroupBackgroundBrushKey"/>
  public static ThemeResourceKey FileTabActiveGroupBackground => EnvironmentColors.FileTabActiveGroupBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabActiveGroupTitleBackgroundBrushKey"/>
  public static ThemeResourceKey FileTabActiveGroupTitleBackground => EnvironmentColors.FileTabActiveGroupTitleBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabBackgroundBrushKey"/>
  public static ThemeResourceKey FileTabBackground => EnvironmentColors.FileTabBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabBorderBrushKey"/>
  public static ThemeResourceKey FileTabBorder => EnvironmentColors.FileTabBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonDownInactiveBrushKey"/>
  public static ThemeResourceKey FileTabButtonDownInactive => EnvironmentColors.FileTabButtonDownInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonDownInactiveBorderBrushKey"/>
  public static ThemeResourceKey FileTabButtonDownInactiveBorder => EnvironmentColors.FileTabButtonDownInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonDownInactiveGlyphBrushKey"/>
  public static ThemeResourceKey FileTabButtonDownInactiveGlyph => EnvironmentColors.FileTabButtonDownInactiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonDownSelectedActiveBrushKey"/>
  public static ThemeResourceKey FileTabButtonDownSelectedActive => EnvironmentColors.FileTabButtonDownSelectedActiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonDownSelectedActiveBorderBrushKey"/>
  public static ThemeResourceKey FileTabButtonDownSelectedActiveBorder => EnvironmentColors.FileTabButtonDownSelectedActiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonDownSelectedActiveGlyphBrushKey"/>
  public static ThemeResourceKey FileTabButtonDownSelectedActiveGlyph => EnvironmentColors.FileTabButtonDownSelectedActiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonDownSelectedInactiveBrushKey"/>
  public static ThemeResourceKey FileTabButtonDownSelectedInactive => EnvironmentColors.FileTabButtonDownSelectedInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonDownSelectedInactiveBorderBrushKey"/>
  public static ThemeResourceKey FileTabButtonDownSelectedInactiveBorder => EnvironmentColors.FileTabButtonDownSelectedInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonDownSelectedInactiveGlyphBrushKey"/>
  public static ThemeResourceKey FileTabButtonDownSelectedInactiveGlyph => EnvironmentColors.FileTabButtonDownSelectedInactiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonHoverInactiveBrushKey"/>
  public static ThemeResourceKey FileTabButtonHoverInactive => EnvironmentColors.FileTabButtonHoverInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonHoverInactiveBorderBrushKey"/>
  public static ThemeResourceKey FileTabButtonHoverInactiveBorder => EnvironmentColors.FileTabButtonHoverInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonHoverInactiveGlyphBrushKey"/>
  public static ThemeResourceKey FileTabButtonHoverInactiveGlyph => EnvironmentColors.FileTabButtonHoverInactiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonHoverSelectedActiveBrushKey"/>
  public static ThemeResourceKey FileTabButtonHoverSelectedActive => EnvironmentColors.FileTabButtonHoverSelectedActiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonHoverSelectedActiveBorderBrushKey"/>
  public static ThemeResourceKey FileTabButtonHoverSelectedActiveBorder => EnvironmentColors.FileTabButtonHoverSelectedActiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonHoverSelectedActiveGlyphBrushKey"/>
  public static ThemeResourceKey FileTabButtonHoverSelectedActiveGlyph => EnvironmentColors.FileTabButtonHoverSelectedActiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonHoverSelectedInactiveBrushKey"/>
  public static ThemeResourceKey FileTabButtonHoverSelectedInactive => EnvironmentColors.FileTabButtonHoverSelectedInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonHoverSelectedInactiveBorderBrushKey"/>
  public static ThemeResourceKey FileTabButtonHoverSelectedInactiveBorder => EnvironmentColors.FileTabButtonHoverSelectedInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonHoverSelectedInactiveGlyphBrushKey"/>
  public static ThemeResourceKey FileTabButtonHoverSelectedInactiveGlyph => EnvironmentColors.FileTabButtonHoverSelectedInactiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalDownInactiveBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalDownInactive => EnvironmentColors.FileTabButtonProvisionalDownInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalDownInactiveBorderBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalDownInactiveBorder => EnvironmentColors.FileTabButtonProvisionalDownInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalDownInactiveGlyphBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalDownInactiveGlyph => EnvironmentColors.FileTabButtonProvisionalDownInactiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalDownSelectedActiveBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalDownSelectedActive => EnvironmentColors.FileTabButtonProvisionalDownSelectedActiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalDownSelectedActiveBorderBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalDownSelectedActiveBorder => EnvironmentColors.FileTabButtonProvisionalDownSelectedActiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalDownSelectedActiveGlyphBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalDownSelectedActiveGlyph => EnvironmentColors.FileTabButtonProvisionalDownSelectedActiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalDownSelectedInactiveBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalDownSelectedInactive => EnvironmentColors.FileTabButtonProvisionalDownSelectedInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalDownSelectedInactiveBorderBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalDownSelectedInactiveBorder => EnvironmentColors.FileTabButtonProvisionalDownSelectedInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalDownSelectedInactiveGlyphBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalDownSelectedInactiveGlyph => EnvironmentColors.FileTabButtonProvisionalDownSelectedInactiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalHoverGlyphBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalHoverGlyph => EnvironmentColors.FileTabButtonProvisionalHoverGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalHoverInactiveBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalHoverInactive => EnvironmentColors.FileTabButtonProvisionalHoverInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalHoverInactiveBorderBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalHoverInactiveBorder => EnvironmentColors.FileTabButtonProvisionalHoverInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalHoverInactiveGlyphBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalHoverInactiveGlyph => EnvironmentColors.FileTabButtonProvisionalHoverInactiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalHoverSelectedActiveBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalHoverSelectedActive => EnvironmentColors.FileTabButtonProvisionalHoverSelectedActiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalHoverSelectedActiveBorderBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalHoverSelectedActiveBorder => EnvironmentColors.FileTabButtonProvisionalHoverSelectedActiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalHoverSelectedActiveGlyphBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalHoverSelectedActiveGlyph => EnvironmentColors.FileTabButtonProvisionalHoverSelectedActiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalHoverSelectedInactiveBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalHoverSelectedInactive => EnvironmentColors.FileTabButtonProvisionalHoverSelectedInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalHoverSelectedInactiveBorderBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalHoverSelectedInactiveBorder => EnvironmentColors.FileTabButtonProvisionalHoverSelectedInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalHoverSelectedInactiveGlyphBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalHoverSelectedInactiveGlyph => EnvironmentColors.FileTabButtonProvisionalHoverSelectedInactiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalInactiveGlyphBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalInactiveGlyph => EnvironmentColors.FileTabButtonProvisionalInactiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalSelectedActiveGlyphBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalSelectedActiveGlyph => EnvironmentColors.FileTabButtonProvisionalSelectedActiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonProvisionalSelectedInactiveGlyphBrushKey"/>
  public static ThemeResourceKey FileTabButtonProvisionalSelectedInactiveGlyph => EnvironmentColors.FileTabButtonProvisionalSelectedInactiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonSelectedActiveGlyphBrushKey"/>
  public static ThemeResourceKey FileTabButtonSelectedActiveGlyph => EnvironmentColors.FileTabButtonSelectedActiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabButtonSelectedInactiveGlyphBrushKey"/>
  public static ThemeResourceKey FileTabButtonSelectedInactiveGlyph => EnvironmentColors.FileTabButtonSelectedInactiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabChannelBackgroundBrushKey"/>
  public static ThemeResourceKey FileTabChannelBackground => EnvironmentColors.FileTabChannelBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabDocumentBorderBackgroundBrushKey"/>
  public static ThemeResourceKey FileTabDocumentBorderBackground => EnvironmentColors.FileTabDocumentBorderBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabDocumentBorderHighlightBrushKey"/>
  public static ThemeResourceKey FileTabDocumentBorderHighlight => EnvironmentColors.FileTabDocumentBorderHighlightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabDocumentBorderShadowBrushKey"/>
  public static ThemeResourceKey FileTabDocumentBorderShadow => EnvironmentColors.FileTabDocumentBorderShadowBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabGradientDarkBrushKey"/>
  public static ThemeResourceKey FileTabGradientDark => EnvironmentColors.FileTabGradientDarkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabGradientLightBrushKey"/>
  public static ThemeResourceKey FileTabGradientLight => EnvironmentColors.FileTabGradientLightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabGroupTitleBackgroundBrushKey"/>
  public static ThemeResourceKey FileTabGroupTitleBackground => EnvironmentColors.FileTabGroupTitleBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabHotBorderBrushKey"/>
  public static ThemeResourceKey FileTabHotBorder => EnvironmentColors.FileTabHotBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabHotGlyphBrushKey"/>
  public static ThemeResourceKey FileTabHotGlyph => EnvironmentColors.FileTabHotGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabHotGradientBottomBrushKey"/>
  public static ThemeResourceKey FileTabHotGradientBottom => EnvironmentColors.FileTabHotGradientBottomBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabHotGradientTopBrushKey"/>
  public static ThemeResourceKey FileTabHotGradientTop => EnvironmentColors.FileTabHotGradientTopBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabHotTextBrushKey"/>
  public static ThemeResourceKey FileTabHotText => EnvironmentColors.FileTabHotTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabInactiveBorderBrushKey"/>
  public static ThemeResourceKey FileTabInactiveBorder => EnvironmentColors.FileTabInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabInactiveDocumentBorderBackgroundBrushKey"/>
  public static ThemeResourceKey FileTabInactiveDocumentBorderBackground => EnvironmentColors.FileTabInactiveDocumentBorderBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabInactiveDocumentBorderEdgeBrushKey"/>
  public static ThemeResourceKey FileTabInactiveDocumentBorderEdge => EnvironmentColors.FileTabInactiveDocumentBorderEdgeBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabInactiveGlyphBrushKey"/>
  public static ThemeResourceKey FileTabInactiveGlyph => EnvironmentColors.FileTabInactiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabInactiveGradientBottomBrushKey"/>
  public static ThemeResourceKey FileTabInactiveGradientBottom => EnvironmentColors.FileTabInactiveGradientBottomBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabInactiveGradientTopBrushKey"/>
  public static ThemeResourceKey FileTabInactiveGradientTop => EnvironmentColors.FileTabInactiveGradientTopBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabInactiveTextBrushKey"/>
  public static ThemeResourceKey FileTabInactiveText => EnvironmentColors.FileTabInactiveTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabIndicatorTextSelectedActiveBrushKey"/>
  public static ThemeResourceKey FileTabIndicatorTextSelectedActive => EnvironmentColors.FileTabIndicatorTextSelectedActiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabIndicatorTextSelectedInactiveBrushKey"/>
  public static ThemeResourceKey FileTabIndicatorTextSelectedInactive => EnvironmentColors.FileTabIndicatorTextSelectedInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabLastActiveDocumentBorderBackgroundBrushKey"/>
  public static ThemeResourceKey FileTabLastActiveDocumentBorderBackground => EnvironmentColors.FileTabLastActiveDocumentBorderBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabLastActiveDocumentBorderEdgeBrushKey"/>
  public static ThemeResourceKey FileTabLastActiveDocumentBorderEdge => EnvironmentColors.FileTabLastActiveDocumentBorderEdgeBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabLastActiveGlyphBrushKey"/>
  public static ThemeResourceKey FileTabLastActiveGlyph => EnvironmentColors.FileTabLastActiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabLastActiveGradientBottomBrushKey"/>
  public static ThemeResourceKey FileTabLastActiveGradientBottom => EnvironmentColors.FileTabLastActiveGradientBottomBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabLastActiveGradientMiddle1BrushKey"/>
  public static ThemeResourceKey FileTabLastActiveGradientMiddle1 => EnvironmentColors.FileTabLastActiveGradientMiddle1BrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabLastActiveGradientMiddle2BrushKey"/>
  public static ThemeResourceKey FileTabLastActiveGradientMiddle2 => EnvironmentColors.FileTabLastActiveGradientMiddle2BrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabLastActiveGradientTopBrushKey"/>
  public static ThemeResourceKey FileTabLastActiveGradientTop => EnvironmentColors.FileTabLastActiveGradientTopBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabLastActiveTextBrushKey"/>
  public static ThemeResourceKey FileTabLastActiveText => EnvironmentColors.FileTabLastActiveTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabParentTextBrushKey"/>
  public static ThemeResourceKey FileTabParentText => EnvironmentColors.FileTabParentTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabPrimarySeparatorBrushKey"/>
  public static ThemeResourceKey FileTabPrimarySeparator => EnvironmentColors.FileTabPrimarySeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabProvisionalHoverBrushKey"/>
  public static ThemeResourceKey FileTabProvisionalHover => EnvironmentColors.FileTabProvisionalHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabProvisionalHoverBorderBrushKey"/>
  public static ThemeResourceKey FileTabProvisionalHoverBorder => EnvironmentColors.FileTabProvisionalHoverBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabProvisionalHoverForegroundBrushKey"/>
  public static ThemeResourceKey FileTabProvisionalHoverForeground => EnvironmentColors.FileTabProvisionalHoverForegroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabProvisionalInactiveBrushKey"/>
  public static ThemeResourceKey FileTabProvisionalInactive => EnvironmentColors.FileTabProvisionalInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabProvisionalInactiveBorderBrushKey"/>
  public static ThemeResourceKey FileTabProvisionalInactiveBorder => EnvironmentColors.FileTabProvisionalInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabProvisionalInactiveForegroundBrushKey"/>
  public static ThemeResourceKey FileTabProvisionalInactiveForeground => EnvironmentColors.FileTabProvisionalInactiveForegroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabProvisionalSelectedActiveBrushKey"/>
  public static ThemeResourceKey FileTabProvisionalSelectedActive => EnvironmentColors.FileTabProvisionalSelectedActiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabProvisionalSelectedActiveBorderBrushKey"/>
  public static ThemeResourceKey FileTabProvisionalSelectedActiveBorder => EnvironmentColors.FileTabProvisionalSelectedActiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabProvisionalSelectedActiveForegroundBrushKey"/>
  public static ThemeResourceKey FileTabProvisionalSelectedActiveForeground => EnvironmentColors.FileTabProvisionalSelectedActiveForegroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabProvisionalSelectedInactiveBrushKey"/>
  public static ThemeResourceKey FileTabProvisionalSelectedInactive => EnvironmentColors.FileTabProvisionalSelectedInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabProvisionalSelectedInactiveBorderBrushKey"/>
  public static ThemeResourceKey FileTabProvisionalSelectedInactiveBorder => EnvironmentColors.FileTabProvisionalSelectedInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabProvisionalSelectedInactiveForegroundBrushKey"/>
  public static ThemeResourceKey FileTabProvisionalSelectedInactiveForeground => EnvironmentColors.FileTabProvisionalSelectedInactiveForegroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabScrollBarArrowGlyphBrushKey"/>
  public static ThemeResourceKey FileTabScrollBarArrowGlyph => EnvironmentColors.FileTabScrollBarArrowGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabScrollBarArrowGlyphHoverBrushKey"/>
  public static ThemeResourceKey FileTabScrollBarArrowGlyphHover => EnvironmentColors.FileTabScrollBarArrowGlyphHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabScrollBarArrowGlyphPressedBrushKey"/>
  public static ThemeResourceKey FileTabScrollBarArrowGlyphPressed => EnvironmentColors.FileTabScrollBarArrowGlyphPressedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabScrollBarThumbBrushKey"/>
  public static ThemeResourceKey FileTabScrollBarThumb => EnvironmentColors.FileTabScrollBarThumbBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabScrollBarThumbHoverBrushKey"/>
  public static ThemeResourceKey FileTabScrollBarThumbHover => EnvironmentColors.FileTabScrollBarThumbHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabScrollBarThumbPressedBrushKey"/>
  public static ThemeResourceKey FileTabScrollBarThumbPressed => EnvironmentColors.FileTabScrollBarThumbPressedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabSecondarySeparatorBrushKey"/>
  public static ThemeResourceKey FileTabSecondarySeparator => EnvironmentColors.FileTabSecondarySeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabSelectedBackgroundBrushKey"/>
  public static ThemeResourceKey FileTabSelectedBackground => EnvironmentColors.FileTabSelectedBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabSelectedBorderBrushKey"/>
  public static ThemeResourceKey FileTabSelectedBorder => EnvironmentColors.FileTabSelectedBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabSelectedGradientBottomBrushKey"/>
  public static ThemeResourceKey FileTabSelectedGradientBottom => EnvironmentColors.FileTabSelectedGradientBottomBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabSelectedGradientMiddle1BrushKey"/>
  public static ThemeResourceKey FileTabSelectedGradientMiddle1 => EnvironmentColors.FileTabSelectedGradientMiddle1BrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabSelectedGradientMiddle2BrushKey"/>
  public static ThemeResourceKey FileTabSelectedGradientMiddle2 => EnvironmentColors.FileTabSelectedGradientMiddle2BrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabSelectedGradientTopBrushKey"/>
  public static ThemeResourceKey FileTabSelectedGradientTop => EnvironmentColors.FileTabSelectedGradientTopBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabSelectedTextBrushKey"/>
  public static ThemeResourceKey FileTabSelectedText => EnvironmentColors.FileTabSelectedTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FileTabTextBrushKey"/>
  public static ThemeResourceKey FileTabText => EnvironmentColors.FileTabTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FormSmartTagActionTagBorderBrushKey"/>
  public static ThemeResourceKey FormSmartTagActionTagBorder => EnvironmentColors.FormSmartTagActionTagBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FormSmartTagActionTagFillBrushKey"/>
  public static ThemeResourceKey FormSmartTagActionTagFill => EnvironmentColors.FormSmartTagActionTagFillBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FormSmartTagObjectTagBorderBrushKey"/>
  public static ThemeResourceKey FormSmartTagObjectTagBorder => EnvironmentColors.FormSmartTagObjectTagBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.FormSmartTagObjectTagFillBrushKey"/>
  public static ThemeResourceKey FormSmartTagObjectTagFill => EnvironmentColors.FormSmartTagObjectTagFillBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemGrayTextBrushKey"/>
  public static ThemeResourceKey SystemGrayText => EnvironmentColors.SystemGrayTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.GridHeadingBackgroundBrushKey"/>
  public static ThemeResourceKey GridHeadingBackground => EnvironmentColors.GridHeadingBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.GridHeadingTextBrushKey"/>
  public static ThemeResourceKey GridHeadingText => EnvironmentColors.GridHeadingTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.GridLineBrushKey"/>
  public static ThemeResourceKey GridLine => EnvironmentColors.GridLineBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HaloBrushKey"/>
  public static ThemeResourceKey Halo => EnvironmentColors.HaloBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpHowDoIPaneBackgroundBrushKey"/>
  public static ThemeResourceKey HelpHowDoIPaneBackground => EnvironmentColors.HelpHowDoIPaneBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpHowDoIPaneLinkBrushKey"/>
  public static ThemeResourceKey HelpHowDoIPaneLink => EnvironmentColors.HelpHowDoIPaneLinkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpHowDoIPaneTextBrushKey"/>
  public static ThemeResourceKey HelpHowDoIPaneText => EnvironmentColors.HelpHowDoIPaneTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpHowDoITaskBackgroundBrushKey"/>
  public static ThemeResourceKey HelpHowDoITaskBackground => EnvironmentColors.HelpHowDoITaskBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpHowDoITaskLinkBrushKey"/>
  public static ThemeResourceKey HelpHowDoITaskLink => EnvironmentColors.HelpHowDoITaskLinkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpHowDoITaskTextBrushKey"/>
  public static ThemeResourceKey HelpHowDoITaskText => EnvironmentColors.HelpHowDoITaskTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpSearchBackgroundBrushKey"/>
  public static ThemeResourceKey HelpSearchBackground => EnvironmentColors.HelpSearchBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpSearchBorderBrushKey"/>
  public static ThemeResourceKey HelpSearchBorder => EnvironmentColors.HelpSearchBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpSearchFilterBackgroundBrushKey"/>
  public static ThemeResourceKey HelpSearchFilterBackground => EnvironmentColors.HelpSearchFilterBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpSearchFilterBorderBrushKey"/>
  public static ThemeResourceKey HelpSearchFilterBorder => EnvironmentColors.HelpSearchFilterBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpSearchFilterTextBrushKey"/>
  public static ThemeResourceKey HelpSearchFilterText => EnvironmentColors.HelpSearchFilterTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpSearchFrameBackgroundBrushKey"/>
  public static ThemeResourceKey HelpSearchFrameBackground => EnvironmentColors.HelpSearchFrameBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpSearchFrameTextBrushKey"/>
  public static ThemeResourceKey HelpSearchFrameText => EnvironmentColors.HelpSearchFrameTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpSearchPanelRulesBrushKey"/>
  public static ThemeResourceKey HelpSearchPanelRules => EnvironmentColors.HelpSearchPanelRulesBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpSearchProviderIconBrushKey"/>
  public static ThemeResourceKey HelpSearchProviderIcon => EnvironmentColors.HelpSearchProviderIconBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpSearchProviderSelectedBackgroundBrushKey"/>
  public static ThemeResourceKey HelpSearchProviderSelectedBackground => EnvironmentColors.HelpSearchProviderSelectedBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpSearchProviderSelectedTextBrushKey"/>
  public static ThemeResourceKey HelpSearchProviderSelectedText => EnvironmentColors.HelpSearchProviderSelectedTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpSearchProviderUnselectedBackgroundBrushKey"/>
  public static ThemeResourceKey HelpSearchProviderUnselectedBackground => EnvironmentColors.HelpSearchProviderUnselectedBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpSearchProviderUnselectedTextBrushKey"/>
  public static ThemeResourceKey HelpSearchProviderUnselectedText => EnvironmentColors.HelpSearchProviderUnselectedTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpSearchResultLinkSelectedBrushKey"/>
  public static ThemeResourceKey HelpSearchResultLinkSelected => EnvironmentColors.HelpSearchResultLinkSelectedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpSearchResultLinkUnselectedBrushKey"/>
  public static ThemeResourceKey HelpSearchResultLinkUnselected => EnvironmentColors.HelpSearchResultLinkUnselectedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpSearchResultSelectedBackgroundBrushKey"/>
  public static ThemeResourceKey HelpSearchResultSelectedBackground => EnvironmentColors.HelpSearchResultSelectedBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpSearchResultSelectedTextBrushKey"/>
  public static ThemeResourceKey HelpSearchResultSelectedText => EnvironmentColors.HelpSearchResultSelectedTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HelpSearchTextBrushKey"/>
  public static ThemeResourceKey HelpSearchText => EnvironmentColors.HelpSearchTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemHighlightBrushKey"/>
  public static ThemeResourceKey SystemHighlight => EnvironmentColors.SystemHighlightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemHighlightTextBrushKey"/>
  public static ThemeResourceKey SystemHighlightText => EnvironmentColors.SystemHighlightTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.HorizontalResizeGripBrushKey"/>
  public static ThemeResourceKey HorizontalResizeGrip => EnvironmentColors.HorizontalResizeGripBrushKey;

  ///<inheritdoc cref="EnvironmentColors.IconActionFillBrushKey"/>
  public static ThemeResourceKey IconActionFill => EnvironmentColors.IconActionFillBrushKey;

  ///<inheritdoc cref="EnvironmentColors.IconGeneralFillBrushKey"/>
  public static ThemeResourceKey IconGeneralFill => EnvironmentColors.IconGeneralFillBrushKey;

  ///<inheritdoc cref="EnvironmentColors.IconGeneralStrokeBrushKey"/>
  public static ThemeResourceKey IconGeneralStroke => EnvironmentColors.IconGeneralStrokeBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemInactiveBorderBrushKey"/>
  public static ThemeResourceKey SystemInactiveBorder => EnvironmentColors.SystemInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.InactiveBorderBrushKey"/>
  public static ThemeResourceKey InactiveBorder => EnvironmentColors.InactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemInactiveCaptionBrushKey"/>
  public static ThemeResourceKey SystemInactiveCaption => EnvironmentColors.SystemInactiveCaptionBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemInactiveCaptionTextBrushKey"/>
  public static ThemeResourceKey SystemInactiveCaptionText => EnvironmentColors.SystemInactiveCaptionTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemInfoBackgroundBrushKey"/>
  public static ThemeResourceKey SystemInfoBackground => EnvironmentColors.SystemInfoBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemInfoTextBrushKey"/>
  public static ThemeResourceKey SystemInfoText => EnvironmentColors.SystemInfoTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.LightBrushKey"/>
  public static ThemeResourceKey Light => EnvironmentColors.LightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.LightCaptionBrushKey"/>
  public static ThemeResourceKey LightCaption => EnvironmentColors.LightCaptionBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowActiveBuildingBorderBrushKey"/>
  public static ThemeResourceKey MainWindowActiveBuildingBorder => EnvironmentColors.MainWindowActiveBuildingBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowActiveCaptionBrushKey"/>
  public static ThemeResourceKey MainWindowActiveCaption => EnvironmentColors.MainWindowActiveCaptionBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowActiveCaptionTextBrushKey"/>
  public static ThemeResourceKey MainWindowActiveCaptionText => EnvironmentColors.MainWindowActiveCaptionTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowActiveDebuggingBorderBrushKey"/>
  public static ThemeResourceKey MainWindowActiveDebuggingBorder => EnvironmentColors.MainWindowActiveDebuggingBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowActiveDefaultBorderBrushKey"/>
  public static ThemeResourceKey MainWindowActiveDefaultBorder => EnvironmentColors.MainWindowActiveDefaultBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowActiveIconBuildingBrushKey"/>
  public static ThemeResourceKey MainWindowActiveIconBuilding => EnvironmentColors.MainWindowActiveIconBuildingBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowActiveIconDebuggingBrushKey"/>
  public static ThemeResourceKey MainWindowActiveIconDebugging => EnvironmentColors.MainWindowActiveIconDebuggingBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowActiveIconDefaultBrushKey"/>
  public static ThemeResourceKey MainWindowActiveIconDefault => EnvironmentColors.MainWindowActiveIconDefaultBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowActiveIconNoSolutionBrushKey"/>
  public static ThemeResourceKey MainWindowActiveIconNoSolution => EnvironmentColors.MainWindowActiveIconNoSolutionBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowActiveNoSolutionBorderBrushKey"/>
  public static ThemeResourceKey MainWindowActiveNoSolutionBorder => EnvironmentColors.MainWindowActiveNoSolutionBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowButtonActiveBorderBrushKey"/>
  public static ThemeResourceKey MainWindowButtonActiveBorder => EnvironmentColors.MainWindowButtonActiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowButtonActiveGlyphBrushKey"/>
  public static ThemeResourceKey MainWindowButtonActiveGlyph => EnvironmentColors.MainWindowButtonActiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowButtonDownBrushKey"/>
  public static ThemeResourceKey MainWindowButtonDown => EnvironmentColors.MainWindowButtonDownBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowButtonDownBorderBrushKey"/>
  public static ThemeResourceKey MainWindowButtonDownBorder => EnvironmentColors.MainWindowButtonDownBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowButtonDownGlyphBrushKey"/>
  public static ThemeResourceKey MainWindowButtonDownGlyph => EnvironmentColors.MainWindowButtonDownGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowButtonHoverActiveBrushKey"/>
  public static ThemeResourceKey MainWindowButtonHoverActive => EnvironmentColors.MainWindowButtonHoverActiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowButtonHoverActiveBorderBrushKey"/>
  public static ThemeResourceKey MainWindowButtonHoverActiveBorder => EnvironmentColors.MainWindowButtonHoverActiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowButtonHoverActiveGlyphBrushKey"/>
  public static ThemeResourceKey MainWindowButtonHoverActiveGlyph => EnvironmentColors.MainWindowButtonHoverActiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowButtonHoverInactiveBrushKey"/>
  public static ThemeResourceKey MainWindowButtonHoverInactive => EnvironmentColors.MainWindowButtonHoverInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowButtonHoverInactiveBorderBrushKey"/>
  public static ThemeResourceKey MainWindowButtonHoverInactiveBorder => EnvironmentColors.MainWindowButtonHoverInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowButtonHoverInactiveGlyphBrushKey"/>
  public static ThemeResourceKey MainWindowButtonHoverInactiveGlyph => EnvironmentColors.MainWindowButtonHoverInactiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowButtonInactiveBorderBrushKey"/>
  public static ThemeResourceKey MainWindowButtonInactiveBorder => EnvironmentColors.MainWindowButtonInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowButtonInactiveGlyphBrushKey"/>
  public static ThemeResourceKey MainWindowButtonInactiveGlyph => EnvironmentColors.MainWindowButtonInactiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowCloudEnvironmentActiveBrushKey"/>
  public static ThemeResourceKey MainWindowCloudEnvironmentActive => EnvironmentColors.MainWindowCloudEnvironmentActiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowCloudEnvironmentActiveTextBrushKey"/>
  public static ThemeResourceKey MainWindowCloudEnvironmentActiveText => EnvironmentColors.MainWindowCloudEnvironmentActiveTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowCloudEnvironmentInactiveBrushKey"/>
  public static ThemeResourceKey MainWindowCloudEnvironmentInactive => EnvironmentColors.MainWindowCloudEnvironmentInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowCloudEnvironmentInactiveTextBrushKey"/>
  public static ThemeResourceKey MainWindowCloudEnvironmentInactiveText => EnvironmentColors.MainWindowCloudEnvironmentInactiveTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowInactiveBorderBrushKey"/>
  public static ThemeResourceKey MainWindowInactiveBorder => EnvironmentColors.MainWindowInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowInactiveCaptionBrushKey"/>
  public static ThemeResourceKey MainWindowInactiveCaption => EnvironmentColors.MainWindowInactiveCaptionBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowInactiveCaptionTextBrushKey"/>
  public static ThemeResourceKey MainWindowInactiveCaptionText => EnvironmentColors.MainWindowInactiveCaptionTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowInactiveIconBuildingBrushKey"/>
  public static ThemeResourceKey MainWindowInactiveIconBuilding => EnvironmentColors.MainWindowInactiveIconBuildingBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowInactiveIconDebuggingBrushKey"/>
  public static ThemeResourceKey MainWindowInactiveIconDebugging => EnvironmentColors.MainWindowInactiveIconDebuggingBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowInactiveIconDefaultBrushKey"/>
  public static ThemeResourceKey MainWindowInactiveIconDefault => EnvironmentColors.MainWindowInactiveIconDefaultBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowInactiveIconNoSolutionBrushKey"/>
  public static ThemeResourceKey MainWindowInactiveIconNoSolution => EnvironmentColors.MainWindowInactiveIconNoSolutionBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowResizeGripTexture1BrushKey"/>
  public static ThemeResourceKey MainWindowResizeGripTexture1 => EnvironmentColors.MainWindowResizeGripTexture1BrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowResizeGripTexture2BrushKey"/>
  public static ThemeResourceKey MainWindowResizeGripTexture2 => EnvironmentColors.MainWindowResizeGripTexture2BrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowSolutionNameActiveBackgroundBrushKey"/>
  public static ThemeResourceKey MainWindowSolutionNameActiveBackground => EnvironmentColors.MainWindowSolutionNameActiveBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowSolutionNameActiveTextBrushKey"/>
  public static ThemeResourceKey MainWindowSolutionNameActiveText => EnvironmentColors.MainWindowSolutionNameActiveTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowSolutionNameInactiveBackgroundBrushKey"/>
  public static ThemeResourceKey MainWindowSolutionNameInactiveBackground => EnvironmentColors.MainWindowSolutionNameInactiveBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MainWindowSolutionNameInactiveTextBrushKey"/>
  public static ThemeResourceKey MainWindowSolutionNameInactiveText => EnvironmentColors.MainWindowSolutionNameInactiveTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MdiClientBorderBrushKey"/>
  public static ThemeResourceKey MdiClientBorder => EnvironmentColors.MdiClientBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.MediumBrushKey"/>
  public static ThemeResourceKey Medium => EnvironmentColors.MediumBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemMenuBrushKey"/>
  public static ThemeResourceKey SystemMenu => EnvironmentColors.SystemMenuBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemMenuTextBrushKey"/>
  public static ThemeResourceKey SystemMenuText => EnvironmentColors.SystemMenuTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.NewProjectBackgroundBrushKey"/>
  public static ThemeResourceKey NewProjectBackground => EnvironmentColors.NewProjectBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.NewProjectItemInactiveBeginBrushKey"/>
  public static ThemeResourceKey NewProjectItemInactiveBegin => EnvironmentColors.NewProjectItemInactiveBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.NewProjectItemInactiveBorderBrushKey"/>
  public static ThemeResourceKey NewProjectItemInactiveBorder => EnvironmentColors.NewProjectItemInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.NewProjectItemInactiveEndBrushKey"/>
  public static ThemeResourceKey NewProjectItemInactiveEnd => EnvironmentColors.NewProjectItemInactiveEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.NewProjectItemSelectedBrushKey"/>
  public static ThemeResourceKey NewProjectItemSelected => EnvironmentColors.NewProjectItemSelectedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.NewProjectItemSelectedBorderBrushKey"/>
  public static ThemeResourceKey NewProjectItemSelectedBorder => EnvironmentColors.NewProjectItemSelectedBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.NewProjectProviderHoverBeginBrushKey"/>
  public static ThemeResourceKey NewProjectProviderHoverBegin => EnvironmentColors.NewProjectProviderHoverBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.NewProjectProviderHoverEndBrushKey"/>
  public static ThemeResourceKey NewProjectProviderHoverEnd => EnvironmentColors.NewProjectProviderHoverEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.NewProjectProviderHoverForegroundBrushKey"/>
  public static ThemeResourceKey NewProjectProviderHoverForeground => EnvironmentColors.NewProjectProviderHoverForegroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.NewProjectProviderHoverMiddle1BrushKey"/>
  public static ThemeResourceKey NewProjectProviderHoverMiddle1 => EnvironmentColors.NewProjectProviderHoverMiddle1BrushKey;

  ///<inheritdoc cref="EnvironmentColors.NewProjectProviderHoverMiddle2BrushKey"/>
  public static ThemeResourceKey NewProjectProviderHoverMiddle2 => EnvironmentColors.NewProjectProviderHoverMiddle2BrushKey;

  ///<inheritdoc cref="EnvironmentColors.NewProjectProviderInactiveBeginBrushKey"/>
  public static ThemeResourceKey NewProjectProviderInactiveBegin => EnvironmentColors.NewProjectProviderInactiveBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.NewProjectProviderInactiveEndBrushKey"/>
  public static ThemeResourceKey NewProjectProviderInactiveEnd => EnvironmentColors.NewProjectProviderInactiveEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.NewProjectProviderInactiveForegroundBrushKey"/>
  public static ThemeResourceKey NewProjectProviderInactiveForeground => EnvironmentColors.NewProjectProviderInactiveForegroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PageContentExpanderChevronBrushKey"/>
  public static ThemeResourceKey PageContentExpanderChevron => EnvironmentColors.PageContentExpanderChevronBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PageContentExpanderSeparatorBrushKey"/>
  public static ThemeResourceKey PageContentExpanderSeparator => EnvironmentColors.PageContentExpanderSeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PageSideBarExpanderBodyBrushKey"/>
  public static ThemeResourceKey PageSideBarExpanderBody => EnvironmentColors.PageSideBarExpanderBodyBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PageSideBarExpanderChevronBrushKey"/>
  public static ThemeResourceKey PageSideBarExpanderChevron => EnvironmentColors.PageSideBarExpanderChevronBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PageSideBarExpanderHeaderBrushKey"/>
  public static ThemeResourceKey PageSideBarExpanderHeader => EnvironmentColors.PageSideBarExpanderHeaderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PageSideBarExpanderHeaderHoverBrushKey"/>
  public static ThemeResourceKey PageSideBarExpanderHeaderHover => EnvironmentColors.PageSideBarExpanderHeaderHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PageSideBarExpanderHeaderPressedBrushKey"/>
  public static ThemeResourceKey PageSideBarExpanderHeaderPressed => EnvironmentColors.PageSideBarExpanderHeaderPressedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PageSideBarExpanderSeparatorBrushKey"/>
  public static ThemeResourceKey PageSideBarExpanderSeparator => EnvironmentColors.PageSideBarExpanderSeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PageSideBarExpanderTextBrushKey"/>
  public static ThemeResourceKey PageSideBarExpanderText => EnvironmentColors.PageSideBarExpanderTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelBorderBrushKey"/>
  public static ThemeResourceKey PanelBorder => EnvironmentColors.PanelBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelDisabledHyperlinkInsideSelectionActiveBrushKey"/>
  public static ThemeResourceKey PanelDisabledHyperlinkInsideSelectionActive => EnvironmentColors.PanelDisabledHyperlinkInsideSelectionActiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelDisabledHyperlinkInsideSelectionActiveTextBrushKey"/>
  public static ThemeResourceKey PanelDisabledHyperlinkInsideSelectionActiveText => EnvironmentColors.PanelDisabledHyperlinkInsideSelectionActiveTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelDisabledHyperlinkInsideSelectionInactiveBrushKey"/>
  public static ThemeResourceKey PanelDisabledHyperlinkInsideSelectionInactive => EnvironmentColors.PanelDisabledHyperlinkInsideSelectionInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelDisabledHyperlinkInsideSelectionInactiveTextBrushKey"/>
  public static ThemeResourceKey PanelDisabledHyperlinkInsideSelectionInactiveText => EnvironmentColors.PanelDisabledHyperlinkInsideSelectionInactiveTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelGradientDarkBrushKey"/>
  public static ThemeResourceKey PanelGradientDark => EnvironmentColors.PanelGradientDarkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelGradientLightBrushKey"/>
  public static ThemeResourceKey PanelGradientLight => EnvironmentColors.PanelGradientLightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelHoverOverCloseBorderBrushKey"/>
  public static ThemeResourceKey PanelHoverOverCloseBorder => EnvironmentColors.PanelHoverOverCloseBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelHoverOverCloseFillBrushKey"/>
  public static ThemeResourceKey PanelHoverOverCloseFill => EnvironmentColors.PanelHoverOverCloseFillBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelHyperlinkBrushKey"/>
  public static ThemeResourceKey PanelHyperlink => EnvironmentColors.PanelHyperlinkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelHyperlinkDisabledBrushKey"/>
  public static ThemeResourceKey PanelHyperlinkDisabled => EnvironmentColors.PanelHyperlinkDisabledBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelHyperlinkHoverBrushKey"/>
  public static ThemeResourceKey PanelHyperlinkHover => EnvironmentColors.PanelHyperlinkHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelHyperlinkInsideSelectionTextBrushKey"/>
  public static ThemeResourceKey PanelHyperlinkInsideSelectionText => EnvironmentColors.PanelHyperlinkInsideSelectionTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelHyperlinkInsideSelectionActiveBrushKey"/>
  public static ThemeResourceKey PanelHyperlinkInsideSelectionActive => EnvironmentColors.PanelHyperlinkInsideSelectionActiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelHyperlinkInsideSelectionActiveTextBrushKey"/>
  public static ThemeResourceKey PanelHyperlinkInsideSelectionActiveText => EnvironmentColors.PanelHyperlinkInsideSelectionActiveTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelHyperlinkInsideSelectionInactiveBrushKey"/>
  public static ThemeResourceKey PanelHyperlinkInsideSelectionInactive => EnvironmentColors.PanelHyperlinkInsideSelectionInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelHyperlinkInsideSelectionInactiveTextBrushKey"/>
  public static ThemeResourceKey PanelHyperlinkInsideSelectionInactiveText => EnvironmentColors.PanelHyperlinkInsideSelectionInactiveTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelHyperlinkPressedBrushKey"/>
  public static ThemeResourceKey PanelHyperlinkPressed => EnvironmentColors.PanelHyperlinkPressedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelSeparatorBrushKey"/>
  public static ThemeResourceKey PanelSeparator => EnvironmentColors.PanelSeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelSubGroupSeparatorBrushKey"/>
  public static ThemeResourceKey PanelSubGroupSeparator => EnvironmentColors.PanelSubGroupSeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelTextBrushKey"/>
  public static ThemeResourceKey PanelText => EnvironmentColors.PanelTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelTitleBarBrushKey"/>
  public static ThemeResourceKey PanelTitleBar => EnvironmentColors.PanelTitleBarBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelTitleBarTextBrushKey"/>
  public static ThemeResourceKey PanelTitleBarText => EnvironmentColors.PanelTitleBarTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.PanelTitleBarUnselectedBrushKey"/>
  public static ThemeResourceKey PanelTitleBarUnselected => EnvironmentColors.PanelTitleBarUnselectedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ProjectDesignerBackgroundGradientBeginBrushKey"/>
  public static ThemeResourceKey ProjectDesignerBackgroundGradientBegin => EnvironmentColors.ProjectDesignerBackgroundGradientBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ProjectDesignerBackgroundGradientEndBrushKey"/>
  public static ThemeResourceKey ProjectDesignerBackgroundGradientEnd => EnvironmentColors.ProjectDesignerBackgroundGradientEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ProjectDesignerBorderInsideBrushKey"/>
  public static ThemeResourceKey ProjectDesignerBorderInside => EnvironmentColors.ProjectDesignerBorderInsideBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ProjectDesignerBorderOutsideBrushKey"/>
  public static ThemeResourceKey ProjectDesignerBorderOutside => EnvironmentColors.ProjectDesignerBorderOutsideBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ProjectDesignerContentsBackgroundBrushKey"/>
  public static ThemeResourceKey ProjectDesignerContentsBackground => EnvironmentColors.ProjectDesignerContentsBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ProjectDesignerTabBackgroundGradientBeginBrushKey"/>
  public static ThemeResourceKey ProjectDesignerTabBackgroundGradientBegin => EnvironmentColors.ProjectDesignerTabBackgroundGradientBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ProjectDesignerTabBackgroundGradientEndBrushKey"/>
  public static ThemeResourceKey ProjectDesignerTabBackgroundGradientEnd => EnvironmentColors.ProjectDesignerTabBackgroundGradientEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ProjectDesignerTabSelectedBackgroundBrushKey"/>
  public static ThemeResourceKey ProjectDesignerTabSelectedBackground => EnvironmentColors.ProjectDesignerTabSelectedBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ProjectDesignerTabSelectedBorderBrushKey"/>
  public static ThemeResourceKey ProjectDesignerTabSelectedBorder => EnvironmentColors.ProjectDesignerTabSelectedBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ProjectDesignerTabSelectedHighlight1BrushKey"/>
  public static ThemeResourceKey ProjectDesignerTabSelectedHighlight1 => EnvironmentColors.ProjectDesignerTabSelectedHighlight1BrushKey;

  ///<inheritdoc cref="EnvironmentColors.ProjectDesignerTabSelectedHighlight2BrushKey"/>
  public static ThemeResourceKey ProjectDesignerTabSelectedHighlight2 => EnvironmentColors.ProjectDesignerTabSelectedHighlight2BrushKey;

  ///<inheritdoc cref="EnvironmentColors.ProjectDesignerTabSelectedInsideBorderBrushKey"/>
  public static ThemeResourceKey ProjectDesignerTabSelectedInsideBorder => EnvironmentColors.ProjectDesignerTabSelectedInsideBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ProjectDesignerTabSepBottomGradientBeginBrushKey"/>
  public static ThemeResourceKey ProjectDesignerTabSepBottomGradientBegin => EnvironmentColors.ProjectDesignerTabSepBottomGradientBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ProjectDesignerTabSepBottomGradientEndBrushKey"/>
  public static ThemeResourceKey ProjectDesignerTabSepBottomGradientEnd => EnvironmentColors.ProjectDesignerTabSepBottomGradientEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ProjectDesignerTabSepTopGradientBeginBrushKey"/>
  public static ThemeResourceKey ProjectDesignerTabSepTopGradientBegin => EnvironmentColors.ProjectDesignerTabSepTopGradientBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ProjectDesignerTabSepTopGradientEndBrushKey"/>
  public static ThemeResourceKey ProjectDesignerTabSepTopGradientEnd => EnvironmentColors.ProjectDesignerTabSepTopGradientEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.QuickCustomizeButtonBrushKey"/>
  public static ThemeResourceKey QuickCustomizeButton => EnvironmentColors.QuickCustomizeButtonBrushKey;

  ///<inheritdoc cref="EnvironmentColors.QuickCustomizeButtonBorderBrushKey"/>
  public static ThemeResourceKey QuickCustomizeButtonBorder => EnvironmentColors.QuickCustomizeButtonBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.QuickCustomizeButtonGlyphBrushKey"/>
  public static ThemeResourceKey QuickCustomizeButtonGlyph => EnvironmentColors.QuickCustomizeButtonGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.QuickCustomizeButtonGlyphHoverBrushKey"/>
  public static ThemeResourceKey QuickCustomizeButtonGlyphHover => EnvironmentColors.QuickCustomizeButtonGlyphHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.QuickCustomizeButtonTextBrushKey"/>
  public static ThemeResourceKey QuickCustomizeButtonText => EnvironmentColors.QuickCustomizeButtonTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.QuickCustomizeButtonTextHoverBrushKey"/>
  public static ThemeResourceKey QuickCustomizeButtonTextHover => EnvironmentColors.QuickCustomizeButtonTextHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowActiveIconBuildingBrushKey"/>
  public static ThemeResourceKey RaftedWindowActiveIconBuilding => EnvironmentColors.RaftedWindowActiveIconBuildingBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowActiveIconDebuggingBrushKey"/>
  public static ThemeResourceKey RaftedWindowActiveIconDebugging => EnvironmentColors.RaftedWindowActiveIconDebuggingBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowActiveIconDefaultBrushKey"/>
  public static ThemeResourceKey RaftedWindowActiveIconDefault => EnvironmentColors.RaftedWindowActiveIconDefaultBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowActiveIconNoSolutionBrushKey"/>
  public static ThemeResourceKey RaftedWindowActiveIconNoSolution => EnvironmentColors.RaftedWindowActiveIconNoSolutionBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowButtonActiveBorderBrushKey"/>
  public static ThemeResourceKey RaftedWindowButtonActiveBorder => EnvironmentColors.RaftedWindowButtonActiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowButtonActiveGlyphBrushKey"/>
  public static ThemeResourceKey RaftedWindowButtonActiveGlyph => EnvironmentColors.RaftedWindowButtonActiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowButtonDownBrushKey"/>
  public static ThemeResourceKey RaftedWindowButtonDown => EnvironmentColors.RaftedWindowButtonDownBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowButtonDownBorderBrushKey"/>
  public static ThemeResourceKey RaftedWindowButtonDownBorder => EnvironmentColors.RaftedWindowButtonDownBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowButtonDownGlyphBrushKey"/>
  public static ThemeResourceKey RaftedWindowButtonDownGlyph => EnvironmentColors.RaftedWindowButtonDownGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowButtonHoverActiveBrushKey"/>
  public static ThemeResourceKey RaftedWindowButtonHoverActive => EnvironmentColors.RaftedWindowButtonHoverActiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowButtonHoverActiveBorderBrushKey"/>
  public static ThemeResourceKey RaftedWindowButtonHoverActiveBorder => EnvironmentColors.RaftedWindowButtonHoverActiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowButtonHoverActiveGlyphBrushKey"/>
  public static ThemeResourceKey RaftedWindowButtonHoverActiveGlyph => EnvironmentColors.RaftedWindowButtonHoverActiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowButtonHoverInactiveBrushKey"/>
  public static ThemeResourceKey RaftedWindowButtonHoverInactive => EnvironmentColors.RaftedWindowButtonHoverInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowButtonHoverInactiveBorderBrushKey"/>
  public static ThemeResourceKey RaftedWindowButtonHoverInactiveBorder => EnvironmentColors.RaftedWindowButtonHoverInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowButtonHoverInactiveGlyphBrushKey"/>
  public static ThemeResourceKey RaftedWindowButtonHoverInactiveGlyph => EnvironmentColors.RaftedWindowButtonHoverInactiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowButtonInactiveBorderBrushKey"/>
  public static ThemeResourceKey RaftedWindowButtonInactiveBorder => EnvironmentColors.RaftedWindowButtonInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowButtonInactiveGlyphBrushKey"/>
  public static ThemeResourceKey RaftedWindowButtonInactiveGlyph => EnvironmentColors.RaftedWindowButtonInactiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowInactiveIconBuildingBrushKey"/>
  public static ThemeResourceKey RaftedWindowInactiveIconBuilding => EnvironmentColors.RaftedWindowInactiveIconBuildingBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowInactiveIconDebuggingBrushKey"/>
  public static ThemeResourceKey RaftedWindowInactiveIconDebugging => EnvironmentColors.RaftedWindowInactiveIconDebuggingBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowInactiveIconDefaultBrushKey"/>
  public static ThemeResourceKey RaftedWindowInactiveIconDefault => EnvironmentColors.RaftedWindowInactiveIconDefaultBrushKey;

  ///<inheritdoc cref="EnvironmentColors.RaftedWindowInactiveIconNoSolutionBrushKey"/>
  public static ThemeResourceKey RaftedWindowInactiveIconNoSolution => EnvironmentColors.RaftedWindowInactiveIconNoSolutionBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScreenTipBackgroundBrushKey"/>
  public static ThemeResourceKey ScreenTipBackground => EnvironmentColors.ScreenTipBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScreenTipBorderBrushKey"/>
  public static ThemeResourceKey ScreenTipBorder => EnvironmentColors.ScreenTipBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScreenTipTextBrushKey"/>
  public static ThemeResourceKey ScreenTipText => EnvironmentColors.ScreenTipTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemScrollBarBrushKey"/>
  public static ThemeResourceKey SystemScrollBar => EnvironmentColors.SystemScrollBarBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarArrowBackgroundBrushKey"/>
  public static ThemeResourceKey ScrollBarArrowBackground => EnvironmentColors.ScrollBarArrowBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarArrowDisabledBackgroundBrushKey"/>
  public static ThemeResourceKey ScrollBarArrowDisabledBackground => EnvironmentColors.ScrollBarArrowDisabledBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarArrowGlyphBrushKey"/>
  public static ThemeResourceKey ScrollBarArrowGlyph => EnvironmentColors.ScrollBarArrowGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarArrowGlyphDisabledBrushKey"/>
  public static ThemeResourceKey ScrollBarArrowGlyphDisabled => EnvironmentColors.ScrollBarArrowGlyphDisabledBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarArrowGlyphMouseOverBrushKey"/>
  public static ThemeResourceKey ScrollBarArrowGlyphMouseOver => EnvironmentColors.ScrollBarArrowGlyphMouseOverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarArrowGlyphPressedBrushKey"/>
  public static ThemeResourceKey ScrollBarArrowGlyphPressed => EnvironmentColors.ScrollBarArrowGlyphPressedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarArrowMouseOverBackgroundBrushKey"/>
  public static ThemeResourceKey ScrollBarArrowMouseOverBackground => EnvironmentColors.ScrollBarArrowMouseOverBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarArrowPressedBackgroundBrushKey"/>
  public static ThemeResourceKey ScrollBarArrowPressedBackground => EnvironmentColors.ScrollBarArrowPressedBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarBackgroundBrushKey"/>
  public static ThemeResourceKey ScrollBarBackground => EnvironmentColors.ScrollBarBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarBorderBrushKey"/>
  public static ThemeResourceKey ScrollBarBorder => EnvironmentColors.ScrollBarBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarDisabledBackgroundBrushKey"/>
  public static ThemeResourceKey ScrollBarDisabledBackground => EnvironmentColors.ScrollBarDisabledBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarThumbBackgroundBrushKey"/>
  public static ThemeResourceKey ScrollBarThumbBackground => EnvironmentColors.ScrollBarThumbBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarThumbBorderBrushKey"/>
  public static ThemeResourceKey ScrollBarThumbBorder => EnvironmentColors.ScrollBarThumbBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarThumbDisabledBrushKey"/>
  public static ThemeResourceKey ScrollBarThumbDisabled => EnvironmentColors.ScrollBarThumbDisabledBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarThumbGlyphBrushKey"/>
  public static ThemeResourceKey ScrollBarThumbGlyph => EnvironmentColors.ScrollBarThumbGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarThumbGlyphMouseOverBorderBrushKey"/>
  public static ThemeResourceKey ScrollBarThumbGlyphMouseOverBorder => EnvironmentColors.ScrollBarThumbGlyphMouseOverBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarThumbGlyphPressedBorderBrushKey"/>
  public static ThemeResourceKey ScrollBarThumbGlyphPressedBorder => EnvironmentColors.ScrollBarThumbGlyphPressedBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarThumbMouseOverBackgroundBrushKey"/>
  public static ThemeResourceKey ScrollBarThumbMouseOverBackground => EnvironmentColors.ScrollBarThumbMouseOverBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarThumbMouseOverBorderBrushKey"/>
  public static ThemeResourceKey ScrollBarThumbMouseOverBorder => EnvironmentColors.ScrollBarThumbMouseOverBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarThumbPressedBackgroundBrushKey"/>
  public static ThemeResourceKey ScrollBarThumbPressedBackground => EnvironmentColors.ScrollBarThumbPressedBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ScrollBarThumbPressedBorderBrushKey"/>
  public static ThemeResourceKey ScrollBarThumbPressedBorder => EnvironmentColors.ScrollBarThumbPressedBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SearchBoxBackgroundBrushKey"/>
  public static ThemeResourceKey SearchBoxBackground => EnvironmentColors.SearchBoxBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SearchBoxBorderBrushKey"/>
  public static ThemeResourceKey SearchBoxBorder => EnvironmentColors.SearchBoxBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SearchBoxMouseOverBackgroundBeginBrushKey"/>
  public static ThemeResourceKey SearchBoxMouseOverBackgroundBegin => EnvironmentColors.SearchBoxMouseOverBackgroundBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SearchBoxMouseOverBackgroundEndBrushKey"/>
  public static ThemeResourceKey SearchBoxMouseOverBackgroundEnd => EnvironmentColors.SearchBoxMouseOverBackgroundEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SearchBoxMouseOverBackgroundMiddle1BrushKey"/>
  public static ThemeResourceKey SearchBoxMouseOverBackgroundMiddle1 => EnvironmentColors.SearchBoxMouseOverBackgroundMiddle1BrushKey;

  ///<inheritdoc cref="EnvironmentColors.SearchBoxMouseOverBackgroundMiddle2BrushKey"/>
  public static ThemeResourceKey SearchBoxMouseOverBackgroundMiddle2 => EnvironmentColors.SearchBoxMouseOverBackgroundMiddle2BrushKey;

  ///<inheritdoc cref="EnvironmentColors.SearchBoxMouseOverBorderBrushKey"/>
  public static ThemeResourceKey SearchBoxMouseOverBorder => EnvironmentColors.SearchBoxMouseOverBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SearchBoxPressedBackgroundBrushKey"/>
  public static ThemeResourceKey SearchBoxPressedBackground => EnvironmentColors.SearchBoxPressedBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SearchBoxPressedBorderBrushKey"/>
  public static ThemeResourceKey SearchBoxPressedBorder => EnvironmentColors.SearchBoxPressedBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SideBarBackgroundBrushKey"/>
  public static ThemeResourceKey SideBarBackground => EnvironmentColors.SideBarBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SideBarGradientDarkBrushKey"/>
  public static ThemeResourceKey SideBarGradientDark => EnvironmentColors.SideBarGradientDarkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SideBarGradientLightBrushKey"/>
  public static ThemeResourceKey SideBarGradientLight => EnvironmentColors.SideBarGradientLightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SideBarTextBrushKey"/>
  public static ThemeResourceKey SideBarText => EnvironmentColors.SideBarTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SmartTagBorderBrushKey"/>
  public static ThemeResourceKey SmartTagBorder => EnvironmentColors.SmartTagBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SmartTagFillBrushKey"/>
  public static ThemeResourceKey SmartTagFill => EnvironmentColors.SmartTagFillBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SmartTagHoverBorderBrushKey"/>
  public static ThemeResourceKey SmartTagHoverBorder => EnvironmentColors.SmartTagHoverBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SmartTagHoverFillBrushKey"/>
  public static ThemeResourceKey SmartTagHoverFill => EnvironmentColors.SmartTagHoverFillBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SmartTagHoverTextBrushKey"/>
  public static ThemeResourceKey SmartTagHoverText => EnvironmentColors.SmartTagHoverTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SmartTagTextBrushKey"/>
  public static ThemeResourceKey SmartTagText => EnvironmentColors.SmartTagTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SnaplinesBrushKey"/>
  public static ThemeResourceKey Snaplines => EnvironmentColors.SnaplinesBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SnaplinesPaddingBrushKey"/>
  public static ThemeResourceKey SnaplinesPadding => EnvironmentColors.SnaplinesPaddingBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SnaplinesTextBaselineBrushKey"/>
  public static ThemeResourceKey SnaplinesTextBaseline => EnvironmentColors.SnaplinesTextBaselineBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SortBackgroundBrushKey"/>
  public static ThemeResourceKey SortBackground => EnvironmentColors.SortBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SortTextBrushKey"/>
  public static ThemeResourceKey SortText => EnvironmentColors.SortTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SplashScreenBorderBrushKey"/>
  public static ThemeResourceKey SplashScreenBorder => EnvironmentColors.SplashScreenBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageBackgroundGradientBeginBrushKey"/>
  public static ThemeResourceKey StartPageBackgroundGradientBegin => EnvironmentColors.StartPageBackgroundGradientBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageBackgroundGradientEndBrushKey"/>
  public static ThemeResourceKey StartPageBackgroundGradientEnd => EnvironmentColors.StartPageBackgroundGradientEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageButtonBorderBrushKey"/>
  public static ThemeResourceKey StartPageButtonBorder => EnvironmentColors.StartPageButtonBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageButtonMouseOverBackgroundBeginBrushKey"/>
  public static ThemeResourceKey StartPageButtonMouseOverBackgroundBegin => EnvironmentColors.StartPageButtonMouseOverBackgroundBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageButtonMouseOverBackgroundEndBrushKey"/>
  public static ThemeResourceKey StartPageButtonMouseOverBackgroundEnd => EnvironmentColors.StartPageButtonMouseOverBackgroundEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageButtonMouseOverBackgroundMiddle1BrushKey"/>
  public static ThemeResourceKey StartPageButtonMouseOverBackgroundMiddle1 => EnvironmentColors.StartPageButtonMouseOverBackgroundMiddle1BrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageButtonMouseOverBackgroundMiddle2BrushKey"/>
  public static ThemeResourceKey StartPageButtonMouseOverBackgroundMiddle2 => EnvironmentColors.StartPageButtonMouseOverBackgroundMiddle2BrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageButtonPinDownBrushKey"/>
  public static ThemeResourceKey StartPageButtonPinDown => EnvironmentColors.StartPageButtonPinDownBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageButtonPinHoverBrushKey"/>
  public static ThemeResourceKey StartPageButtonPinHover => EnvironmentColors.StartPageButtonPinHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageButtonPinnedBrushKey"/>
  public static ThemeResourceKey StartPageButtonPinned => EnvironmentColors.StartPageButtonPinnedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageButtonTextBrushKey"/>
  public static ThemeResourceKey StartPageButtonText => EnvironmentColors.StartPageButtonTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageButtonTextHoverBrushKey"/>
  public static ThemeResourceKey StartPageButtonTextHover => EnvironmentColors.StartPageButtonTextHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageButtonUnpinnedBrushKey"/>
  public static ThemeResourceKey StartPageButtonUnpinned => EnvironmentColors.StartPageButtonUnpinnedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageCheckboxCheckmarkBrushKey"/>
  public static ThemeResourceKey StartPageCheckboxCheckmark => EnvironmentColors.StartPageCheckboxCheckmarkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageSelectedItemBackgroundBrushKey"/>
  public static ThemeResourceKey StartPageSelectedItemBackground => EnvironmentColors.StartPageSelectedItemBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageSelectedItemStrokeBrushKey"/>
  public static ThemeResourceKey StartPageSelectedItemStroke => EnvironmentColors.StartPageSelectedItemStrokeBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageSeparatorBrushKey"/>
  public static ThemeResourceKey StartPageSeparator => EnvironmentColors.StartPageSeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageTabBackgroundBeginBrushKey"/>
  public static ThemeResourceKey StartPageTabBackgroundBegin => EnvironmentColors.StartPageTabBackgroundBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageTabBackgroundEndBrushKey"/>
  public static ThemeResourceKey StartPageTabBackgroundEnd => EnvironmentColors.StartPageTabBackgroundEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageTabMouseOverBackgroundBeginBrushKey"/>
  public static ThemeResourceKey StartPageTabMouseOverBackgroundBegin => EnvironmentColors.StartPageTabMouseOverBackgroundBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageTabMouseOverBackgroundEndBrushKey"/>
  public static ThemeResourceKey StartPageTabMouseOverBackgroundEnd => EnvironmentColors.StartPageTabMouseOverBackgroundEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageTextBodyBrushKey"/>
  public static ThemeResourceKey StartPageTextBody => EnvironmentColors.StartPageTextBodyBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageTextBodySelectedBrushKey"/>
  public static ThemeResourceKey StartPageTextBodySelected => EnvironmentColors.StartPageTextBodySelectedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageTextBodyUnselectedBrushKey"/>
  public static ThemeResourceKey StartPageTextBodyUnselected => EnvironmentColors.StartPageTextBodyUnselectedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageTextControlLinkSelectedBrushKey"/>
  public static ThemeResourceKey StartPageTextControlLinkSelected => EnvironmentColors.StartPageTextControlLinkSelectedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageTextControlLinkSelectedHoverBrushKey"/>
  public static ThemeResourceKey StartPageTextControlLinkSelectedHover => EnvironmentColors.StartPageTextControlLinkSelectedHoverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageTextDateBrushKey"/>
  public static ThemeResourceKey StartPageTextDate => EnvironmentColors.StartPageTextDateBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageTextHeadingBrushKey"/>
  public static ThemeResourceKey StartPageTextHeading => EnvironmentColors.StartPageTextHeadingBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageTextHeadingMouseOverBrushKey"/>
  public static ThemeResourceKey StartPageTextHeadingMouseOver => EnvironmentColors.StartPageTextHeadingMouseOverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageTextHeadingSelectedBrushKey"/>
  public static ThemeResourceKey StartPageTextHeadingSelected => EnvironmentColors.StartPageTextHeadingSelectedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageTextSubHeadingBrushKey"/>
  public static ThemeResourceKey StartPageTextSubHeading => EnvironmentColors.StartPageTextSubHeadingBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageTextSubHeadingMouseOverBrushKey"/>
  public static ThemeResourceKey StartPageTextSubHeadingMouseOver => EnvironmentColors.StartPageTextSubHeadingMouseOverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageTextSubHeadingSelectedBrushKey"/>
  public static ThemeResourceKey StartPageTextSubHeadingSelected => EnvironmentColors.StartPageTextSubHeadingSelectedBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageUnselectedItemBackgroundBeginBrushKey"/>
  public static ThemeResourceKey StartPageUnselectedItemBackgroundBegin => EnvironmentColors.StartPageUnselectedItemBackgroundBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageUnselectedItemBackgroundEndBrushKey"/>
  public static ThemeResourceKey StartPageUnselectedItemBackgroundEnd => EnvironmentColors.StartPageUnselectedItemBackgroundEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StartPageUnselectedItemStrokeBrushKey"/>
  public static ThemeResourceKey StartPageUnselectedItemStroke => EnvironmentColors.StartPageUnselectedItemStrokeBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StatusBarBuildingBrushKey"/>
  public static ThemeResourceKey StatusBarBuilding => EnvironmentColors.StatusBarBuildingBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StatusBarBuildingTextBrushKey"/>
  public static ThemeResourceKey StatusBarBuildingText => EnvironmentColors.StatusBarBuildingTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StatusBarDebuggingBrushKey"/>
  public static ThemeResourceKey StatusBarDebugging => EnvironmentColors.StatusBarDebuggingBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StatusBarDebuggingTextBrushKey"/>
  public static ThemeResourceKey StatusBarDebuggingText => EnvironmentColors.StatusBarDebuggingTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StatusBarDefaultBrushKey"/>
  public static ThemeResourceKey StatusBarDefault => EnvironmentColors.StatusBarDefaultBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StatusBarDefaultTextBrushKey"/>
  public static ThemeResourceKey StatusBarDefaultText => EnvironmentColors.StatusBarDefaultTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StatusBarHighlightBrushKey"/>
  public static ThemeResourceKey StatusBarHighlight => EnvironmentColors.StatusBarHighlightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StatusBarHighlightTextBrushKey"/>
  public static ThemeResourceKey StatusBarHighlightText => EnvironmentColors.StatusBarHighlightTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StatusBarNoSolutionBrushKey"/>
  public static ThemeResourceKey StatusBarNoSolution => EnvironmentColors.StatusBarNoSolutionBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StatusBarNoSolutionTextBrushKey"/>
  public static ThemeResourceKey StatusBarNoSolutionText => EnvironmentColors.StatusBarNoSolutionTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.StatusBarTextBrushKey"/>
  public static ThemeResourceKey StatusBarText => EnvironmentColors.StatusBarTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.TaskListGridLinesBrushKey"/>
  public static ThemeResourceKey TaskListGridLines => EnvironmentColors.TaskListGridLinesBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemThreeDDarkShadowBrushKey"/>
  public static ThemeResourceKey SystemThreeDDarkShadow => EnvironmentColors.SystemThreeDDarkShadowBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemThreeDFaceBrushKey"/>
  public static ThemeResourceKey SystemThreeDFace => EnvironmentColors.SystemThreeDFaceBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemThreeDHighlightBrushKey"/>
  public static ThemeResourceKey SystemThreeDHighlight => EnvironmentColors.SystemThreeDHighlightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemThreeDLightShadowBrushKey"/>
  public static ThemeResourceKey SystemThreeDLightShadow => EnvironmentColors.SystemThreeDLightShadowBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemThreeDShadowBrushKey"/>
  public static ThemeResourceKey SystemThreeDShadow => EnvironmentColors.SystemThreeDShadowBrushKey;

  ///<inheritdoc cref="EnvironmentColors.TitleBarActiveBrushKey"/>
  public static ThemeResourceKey TitleBarActive => EnvironmentColors.TitleBarActiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.TitleBarActiveBorderBrushKey"/>
  public static ThemeResourceKey TitleBarActiveBorder => EnvironmentColors.TitleBarActiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.TitleBarActiveGradientBeginBrushKey"/>
  public static ThemeResourceKey TitleBarActiveGradientBegin => EnvironmentColors.TitleBarActiveGradientBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.TitleBarActiveGradientEndBrushKey"/>
  public static ThemeResourceKey TitleBarActiveGradientEnd => EnvironmentColors.TitleBarActiveGradientEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.TitleBarActiveGradientMiddle1BrushKey"/>
  public static ThemeResourceKey TitleBarActiveGradientMiddle1 => EnvironmentColors.TitleBarActiveGradientMiddle1BrushKey;

  ///<inheritdoc cref="EnvironmentColors.TitleBarActiveGradientMiddle2BrushKey"/>
  public static ThemeResourceKey TitleBarActiveGradientMiddle2 => EnvironmentColors.TitleBarActiveGradientMiddle2BrushKey;

  ///<inheritdoc cref="EnvironmentColors.TitleBarActiveTextBrushKey"/>
  public static ThemeResourceKey TitleBarActiveText => EnvironmentColors.TitleBarActiveTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.TitleBarDragHandleBrushKey"/>
  public static ThemeResourceKey TitleBarDragHandle => EnvironmentColors.TitleBarDragHandleBrushKey;

  ///<inheritdoc cref="EnvironmentColors.TitleBarDragHandleActiveBrushKey"/>
  public static ThemeResourceKey TitleBarDragHandleActive => EnvironmentColors.TitleBarDragHandleActiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.TitleBarInactiveBrushKey"/>
  public static ThemeResourceKey TitleBarInactive => EnvironmentColors.TitleBarInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.TitleBarInactiveGradientBeginBrushKey"/>
  public static ThemeResourceKey TitleBarInactiveGradientBegin => EnvironmentColors.TitleBarInactiveGradientBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.TitleBarInactiveGradientEndBrushKey"/>
  public static ThemeResourceKey TitleBarInactiveGradientEnd => EnvironmentColors.TitleBarInactiveGradientEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.TitleBarInactiveTextBrushKey"/>
  public static ThemeResourceKey TitleBarInactiveText => EnvironmentColors.TitleBarInactiveTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxBackgroundBrushKey"/>
  public static ThemeResourceKey ToolboxBackground => EnvironmentColors.ToolboxBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxContentBrushKey"/>
  public static ThemeResourceKey ToolboxContent => EnvironmentColors.ToolboxContentBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxContentTextBrushKey"/>
  public static ThemeResourceKey ToolboxContentText => EnvironmentColors.ToolboxContentTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxContentMouseOverBrushKey"/>
  public static ThemeResourceKey ToolboxContentMouseOver => EnvironmentColors.ToolboxContentMouseOverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxContentMouseOverTextBrushKey"/>
  public static ThemeResourceKey ToolboxContentMouseOverText => EnvironmentColors.ToolboxContentMouseOverTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxDisabledContentBrushKey"/>
  public static ThemeResourceKey ToolboxDisabledContent => EnvironmentColors.ToolboxDisabledContentBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxDisabledContentTextBrushKey"/>
  public static ThemeResourceKey ToolboxDisabledContentText => EnvironmentColors.ToolboxDisabledContentTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxDisabledContentMouseOverBrushKey"/>
  public static ThemeResourceKey ToolboxDisabledContentMouseOver => EnvironmentColors.ToolboxDisabledContentMouseOverBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxDisabledContentMouseOverTextBrushKey"/>
  public static ThemeResourceKey ToolboxDisabledContentMouseOverText => EnvironmentColors.ToolboxDisabledContentMouseOverTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxDividerBrushKey"/>
  public static ThemeResourceKey ToolboxDivider => EnvironmentColors.ToolboxDividerBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxGradientDarkBrushKey"/>
  public static ThemeResourceKey ToolboxGradientDark => EnvironmentColors.ToolboxGradientDarkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxGradientLightBrushKey"/>
  public static ThemeResourceKey ToolboxGradientLight => EnvironmentColors.ToolboxGradientLightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxHeadingAccentBrushKey"/>
  public static ThemeResourceKey ToolboxHeadingAccent => EnvironmentColors.ToolboxHeadingAccentBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxHeadingBeginBrushKey"/>
  public static ThemeResourceKey ToolboxHeadingBegin => EnvironmentColors.ToolboxHeadingBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxHeadingEndBrushKey"/>
  public static ThemeResourceKey ToolboxHeadingEnd => EnvironmentColors.ToolboxHeadingEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxIconHighlightBrushKey"/>
  public static ThemeResourceKey ToolboxIconHighlight => EnvironmentColors.ToolboxIconHighlightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxIconShadowBrushKey"/>
  public static ThemeResourceKey ToolboxIconShadow => EnvironmentColors.ToolboxIconShadowBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxSelectedHeadingBeginBrushKey"/>
  public static ThemeResourceKey ToolboxSelectedHeadingBegin => EnvironmentColors.ToolboxSelectedHeadingBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxSelectedHeadingEndBrushKey"/>
  public static ThemeResourceKey ToolboxSelectedHeadingEnd => EnvironmentColors.ToolboxSelectedHeadingEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxSelectedHeadingMiddle1BrushKey"/>
  public static ThemeResourceKey ToolboxSelectedHeadingMiddle1 => EnvironmentColors.ToolboxSelectedHeadingMiddle1BrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolboxSelectedHeadingMiddle2BrushKey"/>
  public static ThemeResourceKey ToolboxSelectedHeadingMiddle2 => EnvironmentColors.ToolboxSelectedHeadingMiddle2BrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolTipBrushKey"/>
  public static ThemeResourceKey ToolTip => EnvironmentColors.ToolTipBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolTipTextBrushKey"/>
  public static ThemeResourceKey ToolTipText => EnvironmentColors.ToolTipTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolTipBorderBrushKey"/>
  public static ThemeResourceKey ToolTipBorder => EnvironmentColors.ToolTipBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolTipHintTextBrushKey"/>
  public static ThemeResourceKey ToolTipHintText => EnvironmentColors.ToolTipHintTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowBackgroundBrushKey"/>
  public static ThemeResourceKey ToolWindowBackground => EnvironmentColors.ToolWindowBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowBorderBrushKey"/>
  public static ThemeResourceKey ToolWindowBorder => EnvironmentColors.ToolWindowBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowButtonActiveGlyphBrushKey"/>
  public static ThemeResourceKey ToolWindowButtonActiveGlyph => EnvironmentColors.ToolWindowButtonActiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowButtonDownBrushKey"/>
  public static ThemeResourceKey ToolWindowButtonDown => EnvironmentColors.ToolWindowButtonDownBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowButtonDownActiveGlyphBrushKey"/>
  public static ThemeResourceKey ToolWindowButtonDownActiveGlyph => EnvironmentColors.ToolWindowButtonDownActiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowButtonDownBorderBrushKey"/>
  public static ThemeResourceKey ToolWindowButtonDownBorder => EnvironmentColors.ToolWindowButtonDownBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowButtonDownInactiveGlyphBrushKey"/>
  public static ThemeResourceKey ToolWindowButtonDownInactiveGlyph => EnvironmentColors.ToolWindowButtonDownInactiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowButtonHoverActiveBrushKey"/>
  public static ThemeResourceKey ToolWindowButtonHoverActive => EnvironmentColors.ToolWindowButtonHoverActiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowButtonHoverActiveBorderBrushKey"/>
  public static ThemeResourceKey ToolWindowButtonHoverActiveBorder => EnvironmentColors.ToolWindowButtonHoverActiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowButtonHoverActiveGlyphBrushKey"/>
  public static ThemeResourceKey ToolWindowButtonHoverActiveGlyph => EnvironmentColors.ToolWindowButtonHoverActiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowButtonHoverInactiveBrushKey"/>
  public static ThemeResourceKey ToolWindowButtonHoverInactive => EnvironmentColors.ToolWindowButtonHoverInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowButtonHoverInactiveBorderBrushKey"/>
  public static ThemeResourceKey ToolWindowButtonHoverInactiveBorder => EnvironmentColors.ToolWindowButtonHoverInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowButtonHoverInactiveGlyphBrushKey"/>
  public static ThemeResourceKey ToolWindowButtonHoverInactiveGlyph => EnvironmentColors.ToolWindowButtonHoverInactiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowButtonInactiveBrushKey"/>
  public static ThemeResourceKey ToolWindowButtonInactive => EnvironmentColors.ToolWindowButtonInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowButtonInactiveBorderBrushKey"/>
  public static ThemeResourceKey ToolWindowButtonInactiveBorder => EnvironmentColors.ToolWindowButtonInactiveBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowButtonInactiveGlyphBrushKey"/>
  public static ThemeResourceKey ToolWindowButtonInactiveGlyph => EnvironmentColors.ToolWindowButtonInactiveGlyphBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowContentGridBrushKey"/>
  public static ThemeResourceKey ToolWindowContentGrid => EnvironmentColors.ToolWindowContentGridBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowContentTabGradientBeginBrushKey"/>
  public static ThemeResourceKey ToolWindowContentTabGradientBegin => EnvironmentColors.ToolWindowContentTabGradientBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowContentTabGradientEndBrushKey"/>
  public static ThemeResourceKey ToolWindowContentTabGradientEnd => EnvironmentColors.ToolWindowContentTabGradientEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowFloatingFrameBrushKey"/>
  public static ThemeResourceKey ToolWindowFloatingFrame => EnvironmentColors.ToolWindowFloatingFrameBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowFloatingFrameTextBrushKey"/>
  public static ThemeResourceKey ToolWindowFloatingFrameText => EnvironmentColors.ToolWindowFloatingFrameTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowFloatingFrameInactiveBrushKey"/>
  public static ThemeResourceKey ToolWindowFloatingFrameInactive => EnvironmentColors.ToolWindowFloatingFrameInactiveBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowFloatingFrameInactiveTextBrushKey"/>
  public static ThemeResourceKey ToolWindowFloatingFrameInactiveText => EnvironmentColors.ToolWindowFloatingFrameInactiveTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowTabBorderBrushKey"/>
  public static ThemeResourceKey ToolWindowTabBorder => EnvironmentColors.ToolWindowTabBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowTabGradientBeginBrushKey"/>
  public static ThemeResourceKey ToolWindowTabGradientBegin => EnvironmentColors.ToolWindowTabGradientBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowTabGradientEndBrushKey"/>
  public static ThemeResourceKey ToolWindowTabGradientEnd => EnvironmentColors.ToolWindowTabGradientEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowTabMouseOverBackgroundBeginBrushKey"/>
  public static ThemeResourceKey ToolWindowTabMouseOverBackgroundBegin => EnvironmentColors.ToolWindowTabMouseOverBackgroundBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowTabMouseOverBackgroundEndBrushKey"/>
  public static ThemeResourceKey ToolWindowTabMouseOverBackgroundEnd => EnvironmentColors.ToolWindowTabMouseOverBackgroundEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowTabMouseOverBorderBrushKey"/>
  public static ThemeResourceKey ToolWindowTabMouseOverBorder => EnvironmentColors.ToolWindowTabMouseOverBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowTabMouseOverTextBrushKey"/>
  public static ThemeResourceKey ToolWindowTabMouseOverText => EnvironmentColors.ToolWindowTabMouseOverTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowTabSelectedActiveTextBrushKey"/>
  public static ThemeResourceKey ToolWindowTabSelectedActiveText => EnvironmentColors.ToolWindowTabSelectedActiveTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowTabSelectedBorderBrushKey"/>
  public static ThemeResourceKey ToolWindowTabSelectedBorder => EnvironmentColors.ToolWindowTabSelectedBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowTabSelectedTabBrushKey"/>
  public static ThemeResourceKey ToolWindowTabSelectedTab => EnvironmentColors.ToolWindowTabSelectedTabBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowTabSelectedTextBrushKey"/>
  public static ThemeResourceKey ToolWindowTabSelectedText => EnvironmentColors.ToolWindowTabSelectedTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowTabSeparatorBrushKey"/>
  public static ThemeResourceKey ToolWindowTabSeparator => EnvironmentColors.ToolWindowTabSeparatorBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowTabTextBrushKey"/>
  public static ThemeResourceKey ToolWindowTabText => EnvironmentColors.ToolWindowTabTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowTextBrushKey"/>
  public static ThemeResourceKey ToolWindowText => EnvironmentColors.ToolWindowTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowValidationErrorBorderBrushKey"/>
  public static ThemeResourceKey ToolWindowValidationErrorBorder => EnvironmentColors.ToolWindowValidationErrorBorderBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ToolWindowValidationErrorTextBrushKey"/>
  public static ThemeResourceKey ToolWindowValidationErrorText => EnvironmentColors.ToolWindowValidationErrorTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VerticalResizeGripBeginBrushKey"/>
  public static ThemeResourceKey VerticalResizeGripBegin => EnvironmentColors.VerticalResizeGripBeginBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VerticalResizeGripEndBrushKey"/>
  public static ThemeResourceKey VerticalResizeGripEnd => EnvironmentColors.VerticalResizeGripEndBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VerticalResizeGripMiddleBrushKey"/>
  public static ThemeResourceKey VerticalResizeGripMiddle => EnvironmentColors.VerticalResizeGripMiddleBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceBrownDarkBrushKey"/>
  public static ThemeResourceKey VizSurfaceBrownDark => EnvironmentColors.VizSurfaceBrownDarkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceBrownLightBrushKey"/>
  public static ThemeResourceKey VizSurfaceBrownLight => EnvironmentColors.VizSurfaceBrownLightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceBrownMediumBrushKey"/>
  public static ThemeResourceKey VizSurfaceBrownMedium => EnvironmentColors.VizSurfaceBrownMediumBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceDarkGoldDarkBrushKey"/>
  public static ThemeResourceKey VizSurfaceDarkGoldDark => EnvironmentColors.VizSurfaceDarkGoldDarkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceDarkGoldLightBrushKey"/>
  public static ThemeResourceKey VizSurfaceDarkGoldLight => EnvironmentColors.VizSurfaceDarkGoldLightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceDarkGoldMediumBrushKey"/>
  public static ThemeResourceKey VizSurfaceDarkGoldMedium => EnvironmentColors.VizSurfaceDarkGoldMediumBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceGoldDarkBrushKey"/>
  public static ThemeResourceKey VizSurfaceGoldDark => EnvironmentColors.VizSurfaceGoldDarkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceGoldLightBrushKey"/>
  public static ThemeResourceKey VizSurfaceGoldLight => EnvironmentColors.VizSurfaceGoldLightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceGoldMediumBrushKey"/>
  public static ThemeResourceKey VizSurfaceGoldMedium => EnvironmentColors.VizSurfaceGoldMediumBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceGreenDarkBrushKey"/>
  public static ThemeResourceKey VizSurfaceGreenDark => EnvironmentColors.VizSurfaceGreenDarkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceGreenLightBrushKey"/>
  public static ThemeResourceKey VizSurfaceGreenLight => EnvironmentColors.VizSurfaceGreenLightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceGreenMediumBrushKey"/>
  public static ThemeResourceKey VizSurfaceGreenMedium => EnvironmentColors.VizSurfaceGreenMediumBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfacePlumDarkBrushKey"/>
  public static ThemeResourceKey VizSurfacePlumDark => EnvironmentColors.VizSurfacePlumDarkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfacePlumLightBrushKey"/>
  public static ThemeResourceKey VizSurfacePlumLight => EnvironmentColors.VizSurfacePlumLightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfacePlumMediumBrushKey"/>
  public static ThemeResourceKey VizSurfacePlumMedium => EnvironmentColors.VizSurfacePlumMediumBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceRedDarkBrushKey"/>
  public static ThemeResourceKey VizSurfaceRedDark => EnvironmentColors.VizSurfaceRedDarkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceRedLightBrushKey"/>
  public static ThemeResourceKey VizSurfaceRedLight => EnvironmentColors.VizSurfaceRedLightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceRedMediumBrushKey"/>
  public static ThemeResourceKey VizSurfaceRedMedium => EnvironmentColors.VizSurfaceRedMediumBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceSoftBlueDarkBrushKey"/>
  public static ThemeResourceKey VizSurfaceSoftBlueDark => EnvironmentColors.VizSurfaceSoftBlueDarkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceSoftBlueLightBrushKey"/>
  public static ThemeResourceKey VizSurfaceSoftBlueLight => EnvironmentColors.VizSurfaceSoftBlueLightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceSoftBlueMediumBrushKey"/>
  public static ThemeResourceKey VizSurfaceSoftBlueMedium => EnvironmentColors.VizSurfaceSoftBlueMediumBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceSteelBlueDarkBrushKey"/>
  public static ThemeResourceKey VizSurfaceSteelBlueDark => EnvironmentColors.VizSurfaceSteelBlueDarkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceSteelBlueLightBrushKey"/>
  public static ThemeResourceKey VizSurfaceSteelBlueLight => EnvironmentColors.VizSurfaceSteelBlueLightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceSteelBlueMediumBrushKey"/>
  public static ThemeResourceKey VizSurfaceSteelBlueMedium => EnvironmentColors.VizSurfaceSteelBlueMediumBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceStrongBlueDarkBrushKey"/>
  public static ThemeResourceKey VizSurfaceStrongBlueDark => EnvironmentColors.VizSurfaceStrongBlueDarkBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceStrongBlueLightBrushKey"/>
  public static ThemeResourceKey VizSurfaceStrongBlueLight => EnvironmentColors.VizSurfaceStrongBlueLightBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VizSurfaceStrongBlueMediumBrushKey"/>
  public static ThemeResourceKey VizSurfaceStrongBlueMedium => EnvironmentColors.VizSurfaceStrongBlueMediumBrushKey;

  ///<inheritdoc cref="EnvironmentColors.VSBrandingTextBrushKey"/>
  public static ThemeResourceKey VSBrandingText => EnvironmentColors.VSBrandingTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemWindowBrushKey"/>
  public static ThemeResourceKey SystemWindow => EnvironmentColors.SystemWindowBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemWindowFrameBrushKey"/>
  public static ThemeResourceKey SystemWindowFrame => EnvironmentColors.SystemWindowFrameBrushKey;

  ///<inheritdoc cref="EnvironmentColors.SystemWindowTextBrushKey"/>
  public static ThemeResourceKey SystemWindowText => EnvironmentColors.SystemWindowTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.WizardOrientationPanelBackgroundBrushKey"/>
  public static ThemeResourceKey WizardOrientationPanelBackground => EnvironmentColors.WizardOrientationPanelBackgroundBrushKey;

  ///<inheritdoc cref="EnvironmentColors.WizardOrientationPanelTextBrushKey"/>
  public static ThemeResourceKey WizardOrientationPanelText => EnvironmentColors.WizardOrientationPanelTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.ButtonTextBrushKey"/>
  public static ThemeResourceKey ButtonText => EnvironmentColors.ButtonTextBrushKey;

  ///<inheritdoc cref="EnvironmentColors.TitleBarDragHandleTextureBrushKey"/>
  public static ThemeResourceKey TitleBarDragHandleTexture => EnvironmentColors.TitleBarDragHandleTextureBrushKey;

  ///<inheritdoc cref="EnvironmentColors.TitleBarDragHandleActiveTextureBrushKey"/>
  public static ThemeResourceKey TitleBarDragHandleActiveTexture => EnvironmentColors.TitleBarDragHandleActiveTextureBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarDragHandleHorizontalTextureBrushKey"/>
  public static ThemeResourceKey CommandBarDragHandleHorizontalTexture => EnvironmentColors.CommandBarDragHandleHorizontalTextureBrushKey;

  ///<inheritdoc cref="EnvironmentColors.CommandBarDragHandleVerticalTextureBrushKey"/>
  public static ThemeResourceKey CommandBarDragHandleVerticalTexture => EnvironmentColors.CommandBarDragHandleVerticalTextureBrushKey;

}