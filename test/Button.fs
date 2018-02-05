// ts2fable 0.0.0
module rec Button
open System
open Fable.Core
open Fable.Import.JS
open Fable.Import.Browser

type BaseComponent = ______Utilities.BaseComponent
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IButtonProps = __Button_types.IButtonProps
type IButton = __Button_types.IButton
type BaseButton = __BaseButton.BaseButton
type Button = __Button.Button
type IButtonClassNames = __BaseButton_classNames.IButtonClassNames
type ISplitButtonClassNames = __SplitButton_SplitButton_classNames.ISplitButtonClassNames
type IRenderFunction = ______Utilities.IRenderFunction
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IIconProps = ______Icon.IIconProps
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type BaseComponent = ______Utilities.BaseComponent
type IButtonProps = __Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract BaseButton: BaseButtonStatic
    abstract Button: ButtonStatic
    abstract ActionButton: ActionButtonStatic
    abstract CommandBarButton: CommandBarButtonStatic
    abstract CompoundButton: CompoundButtonStatic
    abstract DefaultButton: DefaultButtonStatic
    abstract MessageBarButton: MessageBarButtonStatic
    abstract PrimaryButton: PrimaryButtonStatic
    abstract IconButton: IconButtonStatic

type [<AllowNullLiteral>] IBaseButtonProps =
    inherit IButtonProps
    abstract baseClassName: string option with get, set
    abstract variantClassName: string option with get, set

type [<AllowNullLiteral>] IBaseButtonState =
    abstract menuProps: IContextualMenuProps option option with get, set

type [<AllowNullLiteral>] BaseButton =
    inherit BaseComponent<IBaseButtonProps, IBaseButtonState>
    inherit IButton
    abstract _isSplitButton: obj
    abstract _isExpanded: obj
    abstract defaultProps: obj with get, set
    abstract _buttonElement: obj with get, set
    abstract _splitButtonContainer: obj with get, set
    abstract _labelId: obj with get, set
    abstract _descriptionId: obj with get, set
    abstract _ariaDescriptionId: obj with get, set
    abstract _classNames: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidUpdate: prevProps: IBaseButtonProps * prevState: IBaseButtonState -> unit
    abstract focus: unit -> unit
    abstract dismissMenu: unit -> unit
    abstract _onRenderContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderIcon: ?buttonProps: obj * ?defaultRender: obj -> unit
    abstract _onRenderTextContents: unit -> unit
    abstract _onRenderText: unit -> unit
    abstract _onRenderChildren: unit -> unit
    abstract _onRenderDescription: props: obj -> unit
    abstract _onRenderAriaDescription: unit -> unit
    abstract _onRenderMenuIcon: props: obj -> unit
    abstract _onRenderMenu: menuProps: obj -> unit
    abstract _dismissMenu: unit -> unit
    abstract _onToggleMenu: unit -> unit
    abstract _onRenderSplitButtonContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderSplitButtonDivider: classNames: obj -> unit
    abstract _onRenderSplitButtonMenuButton: classNames: obj -> unit
    abstract _onMouseDown: ev: obj -> unit
    abstract _onMenuKeyDown: ev: obj -> unit
    abstract _onMenuClick: ev: obj -> unit

type [<AllowNullLiteral>] BaseButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IBaseButtonProps * rootClassName: string -> BaseButton

type [<AllowNullLiteral>] IButton =
    /// Sets focus to the button.
    abstract focus: (unit -> unit) with get, set
    /// If there is a menu associated with this button and it is visible, this will dismiss the menu
    abstract dismissMenu: (unit -> unit) with get, set

type [<AllowNullLiteral>] IButtonProps =
    inherit React.AllHTMLAttributes<U4<HTMLAnchorElement, HTMLButtonElement, BaseButton, Button>>
    /// Optional callback to access the IButton interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IButton -> unit) option with get, set
    /// If provided, this component will be rendered as an anchor.
    abstract href: string option with get, set
    /// Changes the visual presentation of the button to be emphasized (if defined)
    abstract primary: bool option with get, set
    /// Unique id to identify the item. Typically a duplicate of key value.
    abstract uniqueId: U2<string, float> option with get, set
    /// Whether the button is disabled
    abstract disabled: bool option with get, set
    /// If set to true and if this is a splitButton (split == true) then the primary action of a split button is disabled.
    abstract primaryDisabled: bool option with get, set
    /// Custom styling for individual elements within the button DOM.
    abstract styles: IButtonStyles option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Whether the button is checked
    abstract ``checked``: bool option with get, set
    /// If provided, additional class name to provide on the root element.
    abstract className: string option with get, set
    /// The aria label of the button for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// Detailed description of the button for the benefit of screen readers.
    /// 
    /// Besides the compound button, other button types will need more information provided to screen reader.
    abstract ariaDescription: string option with get, set
    /// If provided and is true it adds an 'aria-hidden' attribute instructing screen readers to ignore the element.
    abstract ariaHidden: bool option with get, set
    /// Text to render button label. If text is supplied, it will override any string in button children. Other children components will be passed through after the text.
    abstract text: string option with get, set
    /// The props for the icon shown in the button.
    abstract iconProps: IIconProps option with get, set
    /// Props for button menu. Providing this will default to showing the menu icon. See menuIconProps for overriding
    /// how the default icon looks. Providing this in addition of onClick and setting the split property to true will render a SplitButton.
    abstract menuProps: IContextualMenuProps option with get, set
    /// Callback that runs after Button's contextualmenu was closed (removed from the DOM)
    abstract onAfterMenuDismiss: (unit -> unit) option with get, set
    /// If set to true, and if menuProps and onClick are provided, the button will render as a SplitButton. Defaults to false.
    abstract split: bool option with get, set
    /// The props for the icon shown when providing a menu dropdown.
    abstract menuIconProps: IIconProps option with get, set
    /// Accessible label for the dropdown chevron button if this button is split.
    abstract splitButtonAriaLabel: string option with get, set
    /// Optional callback when menu is clicked.
    abstract onMenuClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IButtonProps -> unit) option with get, set
    /// Custom render function for the icon
    abstract onRenderIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the label text.
    abstract onRenderText: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the desciption text.
    abstract onRenderDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the aria description element.
    abstract onRenderAriaDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for rendering the button children.
    abstract onRenderChildren: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu icon
    abstract onRenderMenuIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu
    abstract onRenderMenu: IRenderFunction<IContextualMenuProps> option with get, set
    /// Description of the action this button takes.
    /// Only used for compound buttons
    abstract description: string option with get, set
    /// Deprecated at v1.2.3, to be removed at >= v2.0.0. Use specific button component instead
    abstract buttonType: ButtonType option with get, set
    /// Deprecated at v0.56.2, to be removed at >= v1.0.0. Just pass in button props instead;
    /// they will be mixed into the button/anchor element rendered by the component.
    abstract rootProps: U2<React.ButtonHTMLAttributes<HTMLButtonElement>, React.AnchorHTMLAttributes<HTMLAnchorElement>> option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract toggled: bool option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract data: obj option option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getClassNames: (ITheme -> string -> string -> string option -> string option -> bool -> bool -> bool -> bool option -> IButtonClassNames) option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getSplitButtonClassNames: (bool -> bool -> bool -> ISplitButtonClassNames) option with get, set

type [<RequireQualifiedAccess>] ElementType =
    | Button = 0
    | Anchor = 1

type [<RequireQualifiedAccess>] ButtonType =
    | Normal = 0
    | Primary = 1
    | Hero = 2
    | Compound = 3
    | Command = 4
    | Icon = 5
    | Default = 6

type [<AllowNullLiteral>] IButtonStyles =
    /// Style for the root element in the default enabled, non-toggled state.
    abstract root: IStyle option with get, set
    /// Style override for the root element in a checked state, layered on top of the root style.
    abstract rootChecked: IStyle option with get, set
    /// Style override for the root element in a disabled state, layered on top of the root style.
    abstract rootDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootHovered: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootFocused: IStyle option with get, set
    /// Style override applied to the root on pressed in the default, enabled, non-toggled state.
    abstract rootPressed: IStyle option with get, set
    /// Style override applied to the root on when menu is expanded in the default, enabled, non-toggled state.
    abstract rootExpanded: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, enabled state
    abstract rootCheckedHovered: IStyle option with get, set
    /// Style override applied to the root on pressed in a checked, enabled state
    abstract rootCheckedPressed: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, disabled state
    abstract rootCheckedDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in a expanded state on hover
    abstract rootExpandedHovered: IStyle option with get, set
    /// Style for the flexbox container within the root element.
    abstract flexContainer: IStyle option with get, set
    /// Style for the text container within the flexbox container element (and contains the text and description).
    abstract textContainer: IStyle option with get, set
    /// Style for the icon on the near side of the label.
    abstract icon: IStyle option with get, set
    /// Style for the icon on the near side of the label on hover.
    abstract iconHovered: IStyle option with get, set
    /// Style for the icon on the near side of the label when pressed.
    abstract iconPressed: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded.
    abstract iconExpanded: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded and hovered.
    abstract iconExpandedHovered: IStyle option with get, set
    /// Style override for the icon when the button is disabled.
    abstract iconDisabled: IStyle option with get, set
    /// Style override for the icon when the button is checked.
    abstract iconChecked: IStyle option with get, set
    /// Style for the text content of the button.
    abstract label: IStyle option with get, set
    /// Style override for the text content when the button is disabled.
    abstract labelDisabled: IStyle option with get, set
    /// Style override for the text content when the button is checked.
    abstract labelChecked: IStyle option with get, set
    /// Style for the menu chevron.
    abstract menuIcon: IStyle option with get, set
    /// Style for the menu chevron on hover.
    abstract menuIconHovered: IStyle option with get, set
    /// Style for the menu chevron when pressed.
    abstract menuIconPressed: IStyle option with get, set
    /// Style for the menu chevron when expanded.
    abstract menuIconExpanded: IStyle option with get, set
    /// Style for the menu chevron when expanded and hovered.
    abstract menuIconExpandedHovered: IStyle option with get, set
    /// Style override for the menu chevron when the button is disabled.
    abstract menuIconDisabled: IStyle option with get, set
    /// Style override for the menu chevron when the button is checked.
    abstract menuIconChecked: IStyle option with get, set
    /// Style for the description text if applicable (for compound buttons.)
    abstract description: IStyle option with get, set
    /// Style override for the description text when the button is hovered.
    abstract descriptionHovered: IStyle option with get, set
    /// Style for the description text when the button is pressed.
    abstract descriptionPressed: IStyle option with get, set
    /// Style override for the description text when the button is disabled.
    abstract descriptionDisabled: IStyle option with get, set
    /// Style override for the description text when the button is checked.
    abstract descriptionChecked: IStyle option with get, set
    /// Style override for the screen reader text.
    abstract screenReaderText: IStyle option with get, set
    /// Style override for the container div around a SplitButton element
    abstract splitButtonContainer: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is hovered.
    abstract splitButtonContainerHovered: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is focused.
    abstract splitButtonContainerFocused: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked.
    abstract splitButtonContainerChecked: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked and hovered.
    abstract splitButtonContainerCheckedHovered: IStyle option with get, set
    /// Style override for the container div around a SplitButton element in a disabled state
    abstract splitButtonContainerDisabled: IStyle option with get, set
    /// Style override for the divider element that appears between the button and menu button
    /// for a split button.
    abstract splitButtonDivider: IStyle option with get, set
    /// Style override for the SplitButton menu button
    abstract splitButtonMenuButton: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a disabled state.
    abstract splitButtonMenuButtonDisabled: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a checked state
    abstract splitButtonMenuButtonChecked: IStyle option with get, set
    /// Style override for the SplitButton menu button element in an expanded state
    abstract splitButtonMenuButtonExpanded: IStyle option with get, set
    /// Style override for the SplitButton menu icon element
    abstract splitButtonMenuIcon: IStyle option with get, set
    /// Style override for the SplitButton menu icon element in a disabled state
    abstract splitButtonMenuIconDisabled: IStyle option with get, set
    /// Style override for the SplitButton FlexContainer.
    abstract splitButtonFlexContainer: IStyle option with get, set

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] Button =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] ButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IButtonProps -> Button

type [<AllowNullLiteral>] ActionButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] ActionButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ActionButton

type [<AllowNullLiteral>] CommandBarButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CommandBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CommandBarButton

type [<AllowNullLiteral>] CompoundButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CompoundButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CompoundButton

type [<AllowNullLiteral>] DefaultButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DefaultButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DefaultButton

type [<AllowNullLiteral>] MessageBarButton =
    inherit BaseComponent<IButtonProps, obj>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] MessageBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> MessageBarButton

type [<AllowNullLiteral>] PrimaryButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] PrimaryButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> PrimaryButton

type [<AllowNullLiteral>] IconButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] IconButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> IconButton
type BaseComponent = ______Utilities.BaseComponent
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IButtonProps = __Button_types.IButtonProps
type IButton = __Button_types.IButton
type BaseButton = __BaseButton.BaseButton
type Button = __Button.Button
type IButtonClassNames = __BaseButton_classNames.IButtonClassNames
type ISplitButtonClassNames = __SplitButton_SplitButton_classNames.ISplitButtonClassNames
type IRenderFunction = ______Utilities.IRenderFunction
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IIconProps = ______Icon.IIconProps
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type BaseComponent = ______Utilities.BaseComponent
type IButtonProps = __Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract BaseButton: BaseButtonStatic
    abstract Button: ButtonStatic
    abstract ActionButton: ActionButtonStatic
    abstract CommandBarButton: CommandBarButtonStatic
    abstract CompoundButton: CompoundButtonStatic
    abstract DefaultButton: DefaultButtonStatic
    abstract MessageBarButton: MessageBarButtonStatic
    abstract PrimaryButton: PrimaryButtonStatic
    abstract IconButton: IconButtonStatic

type [<AllowNullLiteral>] IBaseButtonProps =
    inherit IButtonProps
    abstract baseClassName: string option with get, set
    abstract variantClassName: string option with get, set

type [<AllowNullLiteral>] IBaseButtonState =
    abstract menuProps: IContextualMenuProps option option with get, set

type [<AllowNullLiteral>] BaseButton =
    inherit BaseComponent<IBaseButtonProps, IBaseButtonState>
    inherit IButton
    abstract _isSplitButton: obj
    abstract _isExpanded: obj
    abstract defaultProps: obj with get, set
    abstract _buttonElement: obj with get, set
    abstract _splitButtonContainer: obj with get, set
    abstract _labelId: obj with get, set
    abstract _descriptionId: obj with get, set
    abstract _ariaDescriptionId: obj with get, set
    abstract _classNames: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidUpdate: prevProps: IBaseButtonProps * prevState: IBaseButtonState -> unit
    abstract focus: unit -> unit
    abstract dismissMenu: unit -> unit
    abstract _onRenderContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderIcon: ?buttonProps: obj * ?defaultRender: obj -> unit
    abstract _onRenderTextContents: unit -> unit
    abstract _onRenderText: unit -> unit
    abstract _onRenderChildren: unit -> unit
    abstract _onRenderDescription: props: obj -> unit
    abstract _onRenderAriaDescription: unit -> unit
    abstract _onRenderMenuIcon: props: obj -> unit
    abstract _onRenderMenu: menuProps: obj -> unit
    abstract _dismissMenu: unit -> unit
    abstract _onToggleMenu: unit -> unit
    abstract _onRenderSplitButtonContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderSplitButtonDivider: classNames: obj -> unit
    abstract _onRenderSplitButtonMenuButton: classNames: obj -> unit
    abstract _onMouseDown: ev: obj -> unit
    abstract _onMenuKeyDown: ev: obj -> unit
    abstract _onMenuClick: ev: obj -> unit

type [<AllowNullLiteral>] BaseButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IBaseButtonProps * rootClassName: string -> BaseButton

type [<AllowNullLiteral>] IButton =
    /// Sets focus to the button.
    abstract focus: (unit -> unit) with get, set
    /// If there is a menu associated with this button and it is visible, this will dismiss the menu
    abstract dismissMenu: (unit -> unit) with get, set

type [<AllowNullLiteral>] IButtonProps =
    inherit React.AllHTMLAttributes<U4<HTMLAnchorElement, HTMLButtonElement, BaseButton, Button>>
    /// Optional callback to access the IButton interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IButton -> unit) option with get, set
    /// If provided, this component will be rendered as an anchor.
    abstract href: string option with get, set
    /// Changes the visual presentation of the button to be emphasized (if defined)
    abstract primary: bool option with get, set
    /// Unique id to identify the item. Typically a duplicate of key value.
    abstract uniqueId: U2<string, float> option with get, set
    /// Whether the button is disabled
    abstract disabled: bool option with get, set
    /// If set to true and if this is a splitButton (split == true) then the primary action of a split button is disabled.
    abstract primaryDisabled: bool option with get, set
    /// Custom styling for individual elements within the button DOM.
    abstract styles: IButtonStyles option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Whether the button is checked
    abstract ``checked``: bool option with get, set
    /// If provided, additional class name to provide on the root element.
    abstract className: string option with get, set
    /// The aria label of the button for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// Detailed description of the button for the benefit of screen readers.
    /// 
    /// Besides the compound button, other button types will need more information provided to screen reader.
    abstract ariaDescription: string option with get, set
    /// If provided and is true it adds an 'aria-hidden' attribute instructing screen readers to ignore the element.
    abstract ariaHidden: bool option with get, set
    /// Text to render button label. If text is supplied, it will override any string in button children. Other children components will be passed through after the text.
    abstract text: string option with get, set
    /// The props for the icon shown in the button.
    abstract iconProps: IIconProps option with get, set
    /// Props for button menu. Providing this will default to showing the menu icon. See menuIconProps for overriding
    /// how the default icon looks. Providing this in addition of onClick and setting the split property to true will render a SplitButton.
    abstract menuProps: IContextualMenuProps option with get, set
    /// Callback that runs after Button's contextualmenu was closed (removed from the DOM)
    abstract onAfterMenuDismiss: (unit -> unit) option with get, set
    /// If set to true, and if menuProps and onClick are provided, the button will render as a SplitButton. Defaults to false.
    abstract split: bool option with get, set
    /// The props for the icon shown when providing a menu dropdown.
    abstract menuIconProps: IIconProps option with get, set
    /// Accessible label for the dropdown chevron button if this button is split.
    abstract splitButtonAriaLabel: string option with get, set
    /// Optional callback when menu is clicked.
    abstract onMenuClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IButtonProps -> unit) option with get, set
    /// Custom render function for the icon
    abstract onRenderIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the label text.
    abstract onRenderText: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the desciption text.
    abstract onRenderDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the aria description element.
    abstract onRenderAriaDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for rendering the button children.
    abstract onRenderChildren: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu icon
    abstract onRenderMenuIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu
    abstract onRenderMenu: IRenderFunction<IContextualMenuProps> option with get, set
    /// Description of the action this button takes.
    /// Only used for compound buttons
    abstract description: string option with get, set
    /// Deprecated at v1.2.3, to be removed at >= v2.0.0. Use specific button component instead
    abstract buttonType: ButtonType option with get, set
    /// Deprecated at v0.56.2, to be removed at >= v1.0.0. Just pass in button props instead;
    /// they will be mixed into the button/anchor element rendered by the component.
    abstract rootProps: U2<React.ButtonHTMLAttributes<HTMLButtonElement>, React.AnchorHTMLAttributes<HTMLAnchorElement>> option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract toggled: bool option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract data: obj option option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getClassNames: (ITheme -> string -> string -> string option -> string option -> bool -> bool -> bool -> bool option -> IButtonClassNames) option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getSplitButtonClassNames: (bool -> bool -> bool -> ISplitButtonClassNames) option with get, set

type [<RequireQualifiedAccess>] ElementType =
    | Button = 0
    | Anchor = 1

type [<RequireQualifiedAccess>] ButtonType =
    | Normal = 0
    | Primary = 1
    | Hero = 2
    | Compound = 3
    | Command = 4
    | Icon = 5
    | Default = 6

type [<AllowNullLiteral>] IButtonStyles =
    /// Style for the root element in the default enabled, non-toggled state.
    abstract root: IStyle option with get, set
    /// Style override for the root element in a checked state, layered on top of the root style.
    abstract rootChecked: IStyle option with get, set
    /// Style override for the root element in a disabled state, layered on top of the root style.
    abstract rootDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootHovered: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootFocused: IStyle option with get, set
    /// Style override applied to the root on pressed in the default, enabled, non-toggled state.
    abstract rootPressed: IStyle option with get, set
    /// Style override applied to the root on when menu is expanded in the default, enabled, non-toggled state.
    abstract rootExpanded: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, enabled state
    abstract rootCheckedHovered: IStyle option with get, set
    /// Style override applied to the root on pressed in a checked, enabled state
    abstract rootCheckedPressed: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, disabled state
    abstract rootCheckedDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in a expanded state on hover
    abstract rootExpandedHovered: IStyle option with get, set
    /// Style for the flexbox container within the root element.
    abstract flexContainer: IStyle option with get, set
    /// Style for the text container within the flexbox container element (and contains the text and description).
    abstract textContainer: IStyle option with get, set
    /// Style for the icon on the near side of the label.
    abstract icon: IStyle option with get, set
    /// Style for the icon on the near side of the label on hover.
    abstract iconHovered: IStyle option with get, set
    /// Style for the icon on the near side of the label when pressed.
    abstract iconPressed: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded.
    abstract iconExpanded: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded and hovered.
    abstract iconExpandedHovered: IStyle option with get, set
    /// Style override for the icon when the button is disabled.
    abstract iconDisabled: IStyle option with get, set
    /// Style override for the icon when the button is checked.
    abstract iconChecked: IStyle option with get, set
    /// Style for the text content of the button.
    abstract label: IStyle option with get, set
    /// Style override for the text content when the button is disabled.
    abstract labelDisabled: IStyle option with get, set
    /// Style override for the text content when the button is checked.
    abstract labelChecked: IStyle option with get, set
    /// Style for the menu chevron.
    abstract menuIcon: IStyle option with get, set
    /// Style for the menu chevron on hover.
    abstract menuIconHovered: IStyle option with get, set
    /// Style for the menu chevron when pressed.
    abstract menuIconPressed: IStyle option with get, set
    /// Style for the menu chevron when expanded.
    abstract menuIconExpanded: IStyle option with get, set
    /// Style for the menu chevron when expanded and hovered.
    abstract menuIconExpandedHovered: IStyle option with get, set
    /// Style override for the menu chevron when the button is disabled.
    abstract menuIconDisabled: IStyle option with get, set
    /// Style override for the menu chevron when the button is checked.
    abstract menuIconChecked: IStyle option with get, set
    /// Style for the description text if applicable (for compound buttons.)
    abstract description: IStyle option with get, set
    /// Style override for the description text when the button is hovered.
    abstract descriptionHovered: IStyle option with get, set
    /// Style for the description text when the button is pressed.
    abstract descriptionPressed: IStyle option with get, set
    /// Style override for the description text when the button is disabled.
    abstract descriptionDisabled: IStyle option with get, set
    /// Style override for the description text when the button is checked.
    abstract descriptionChecked: IStyle option with get, set
    /// Style override for the screen reader text.
    abstract screenReaderText: IStyle option with get, set
    /// Style override for the container div around a SplitButton element
    abstract splitButtonContainer: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is hovered.
    abstract splitButtonContainerHovered: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is focused.
    abstract splitButtonContainerFocused: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked.
    abstract splitButtonContainerChecked: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked and hovered.
    abstract splitButtonContainerCheckedHovered: IStyle option with get, set
    /// Style override for the container div around a SplitButton element in a disabled state
    abstract splitButtonContainerDisabled: IStyle option with get, set
    /// Style override for the divider element that appears between the button and menu button
    /// for a split button.
    abstract splitButtonDivider: IStyle option with get, set
    /// Style override for the SplitButton menu button
    abstract splitButtonMenuButton: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a disabled state.
    abstract splitButtonMenuButtonDisabled: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a checked state
    abstract splitButtonMenuButtonChecked: IStyle option with get, set
    /// Style override for the SplitButton menu button element in an expanded state
    abstract splitButtonMenuButtonExpanded: IStyle option with get, set
    /// Style override for the SplitButton menu icon element
    abstract splitButtonMenuIcon: IStyle option with get, set
    /// Style override for the SplitButton menu icon element in a disabled state
    abstract splitButtonMenuIconDisabled: IStyle option with get, set
    /// Style override for the SplitButton FlexContainer.
    abstract splitButtonFlexContainer: IStyle option with get, set

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] Button =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] ButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IButtonProps -> Button

type [<AllowNullLiteral>] ActionButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] ActionButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ActionButton

type [<AllowNullLiteral>] CommandBarButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CommandBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CommandBarButton

type [<AllowNullLiteral>] CompoundButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CompoundButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CompoundButton

type [<AllowNullLiteral>] DefaultButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DefaultButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DefaultButton

type [<AllowNullLiteral>] MessageBarButton =
    inherit BaseComponent<IButtonProps, obj>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] MessageBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> MessageBarButton

type [<AllowNullLiteral>] PrimaryButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] PrimaryButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> PrimaryButton

type [<AllowNullLiteral>] IconButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] IconButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> IconButton
type BaseComponent = ______Utilities.BaseComponent
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IButtonProps = __Button_types.IButtonProps
type IButton = __Button_types.IButton
type BaseButton = __BaseButton.BaseButton
type Button = __Button.Button
type IButtonClassNames = __BaseButton_classNames.IButtonClassNames
type ISplitButtonClassNames = __SplitButton_SplitButton_classNames.ISplitButtonClassNames
type IRenderFunction = ______Utilities.IRenderFunction
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IIconProps = ______Icon.IIconProps
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type BaseComponent = ______Utilities.BaseComponent
type IButtonProps = __Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract BaseButton: BaseButtonStatic
    abstract Button: ButtonStatic
    abstract ActionButton: ActionButtonStatic
    abstract CommandBarButton: CommandBarButtonStatic
    abstract CompoundButton: CompoundButtonStatic
    abstract DefaultButton: DefaultButtonStatic
    abstract MessageBarButton: MessageBarButtonStatic
    abstract PrimaryButton: PrimaryButtonStatic
    abstract IconButton: IconButtonStatic

type [<AllowNullLiteral>] IBaseButtonProps =
    inherit IButtonProps
    abstract baseClassName: string option with get, set
    abstract variantClassName: string option with get, set

type [<AllowNullLiteral>] IBaseButtonState =
    abstract menuProps: IContextualMenuProps option option with get, set

type [<AllowNullLiteral>] BaseButton =
    inherit BaseComponent<IBaseButtonProps, IBaseButtonState>
    inherit IButton
    abstract _isSplitButton: obj
    abstract _isExpanded: obj
    abstract defaultProps: obj with get, set
    abstract _buttonElement: obj with get, set
    abstract _splitButtonContainer: obj with get, set
    abstract _labelId: obj with get, set
    abstract _descriptionId: obj with get, set
    abstract _ariaDescriptionId: obj with get, set
    abstract _classNames: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidUpdate: prevProps: IBaseButtonProps * prevState: IBaseButtonState -> unit
    abstract focus: unit -> unit
    abstract dismissMenu: unit -> unit
    abstract _onRenderContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderIcon: ?buttonProps: obj * ?defaultRender: obj -> unit
    abstract _onRenderTextContents: unit -> unit
    abstract _onRenderText: unit -> unit
    abstract _onRenderChildren: unit -> unit
    abstract _onRenderDescription: props: obj -> unit
    abstract _onRenderAriaDescription: unit -> unit
    abstract _onRenderMenuIcon: props: obj -> unit
    abstract _onRenderMenu: menuProps: obj -> unit
    abstract _dismissMenu: unit -> unit
    abstract _onToggleMenu: unit -> unit
    abstract _onRenderSplitButtonContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderSplitButtonDivider: classNames: obj -> unit
    abstract _onRenderSplitButtonMenuButton: classNames: obj -> unit
    abstract _onMouseDown: ev: obj -> unit
    abstract _onMenuKeyDown: ev: obj -> unit
    abstract _onMenuClick: ev: obj -> unit

type [<AllowNullLiteral>] BaseButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IBaseButtonProps * rootClassName: string -> BaseButton

type [<AllowNullLiteral>] IButton =
    /// Sets focus to the button.
    abstract focus: (unit -> unit) with get, set
    /// If there is a menu associated with this button and it is visible, this will dismiss the menu
    abstract dismissMenu: (unit -> unit) with get, set

type [<AllowNullLiteral>] IButtonProps =
    inherit React.AllHTMLAttributes<U4<HTMLAnchorElement, HTMLButtonElement, BaseButton, Button>>
    /// Optional callback to access the IButton interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IButton -> unit) option with get, set
    /// If provided, this component will be rendered as an anchor.
    abstract href: string option with get, set
    /// Changes the visual presentation of the button to be emphasized (if defined)
    abstract primary: bool option with get, set
    /// Unique id to identify the item. Typically a duplicate of key value.
    abstract uniqueId: U2<string, float> option with get, set
    /// Whether the button is disabled
    abstract disabled: bool option with get, set
    /// If set to true and if this is a splitButton (split == true) then the primary action of a split button is disabled.
    abstract primaryDisabled: bool option with get, set
    /// Custom styling for individual elements within the button DOM.
    abstract styles: IButtonStyles option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Whether the button is checked
    abstract ``checked``: bool option with get, set
    /// If provided, additional class name to provide on the root element.
    abstract className: string option with get, set
    /// The aria label of the button for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// Detailed description of the button for the benefit of screen readers.
    /// 
    /// Besides the compound button, other button types will need more information provided to screen reader.
    abstract ariaDescription: string option with get, set
    /// If provided and is true it adds an 'aria-hidden' attribute instructing screen readers to ignore the element.
    abstract ariaHidden: bool option with get, set
    /// Text to render button label. If text is supplied, it will override any string in button children. Other children components will be passed through after the text.
    abstract text: string option with get, set
    /// The props for the icon shown in the button.
    abstract iconProps: IIconProps option with get, set
    /// Props for button menu. Providing this will default to showing the menu icon. See menuIconProps for overriding
    /// how the default icon looks. Providing this in addition of onClick and setting the split property to true will render a SplitButton.
    abstract menuProps: IContextualMenuProps option with get, set
    /// Callback that runs after Button's contextualmenu was closed (removed from the DOM)
    abstract onAfterMenuDismiss: (unit -> unit) option with get, set
    /// If set to true, and if menuProps and onClick are provided, the button will render as a SplitButton. Defaults to false.
    abstract split: bool option with get, set
    /// The props for the icon shown when providing a menu dropdown.
    abstract menuIconProps: IIconProps option with get, set
    /// Accessible label for the dropdown chevron button if this button is split.
    abstract splitButtonAriaLabel: string option with get, set
    /// Optional callback when menu is clicked.
    abstract onMenuClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IButtonProps -> unit) option with get, set
    /// Custom render function for the icon
    abstract onRenderIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the label text.
    abstract onRenderText: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the desciption text.
    abstract onRenderDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the aria description element.
    abstract onRenderAriaDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for rendering the button children.
    abstract onRenderChildren: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu icon
    abstract onRenderMenuIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu
    abstract onRenderMenu: IRenderFunction<IContextualMenuProps> option with get, set
    /// Description of the action this button takes.
    /// Only used for compound buttons
    abstract description: string option with get, set
    /// Deprecated at v1.2.3, to be removed at >= v2.0.0. Use specific button component instead
    abstract buttonType: ButtonType option with get, set
    /// Deprecated at v0.56.2, to be removed at >= v1.0.0. Just pass in button props instead;
    /// they will be mixed into the button/anchor element rendered by the component.
    abstract rootProps: U2<React.ButtonHTMLAttributes<HTMLButtonElement>, React.AnchorHTMLAttributes<HTMLAnchorElement>> option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract toggled: bool option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract data: obj option option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getClassNames: (ITheme -> string -> string -> string option -> string option -> bool -> bool -> bool -> bool option -> IButtonClassNames) option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getSplitButtonClassNames: (bool -> bool -> bool -> ISplitButtonClassNames) option with get, set

type [<RequireQualifiedAccess>] ElementType =
    | Button = 0
    | Anchor = 1

type [<RequireQualifiedAccess>] ButtonType =
    | Normal = 0
    | Primary = 1
    | Hero = 2
    | Compound = 3
    | Command = 4
    | Icon = 5
    | Default = 6

type [<AllowNullLiteral>] IButtonStyles =
    /// Style for the root element in the default enabled, non-toggled state.
    abstract root: IStyle option with get, set
    /// Style override for the root element in a checked state, layered on top of the root style.
    abstract rootChecked: IStyle option with get, set
    /// Style override for the root element in a disabled state, layered on top of the root style.
    abstract rootDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootHovered: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootFocused: IStyle option with get, set
    /// Style override applied to the root on pressed in the default, enabled, non-toggled state.
    abstract rootPressed: IStyle option with get, set
    /// Style override applied to the root on when menu is expanded in the default, enabled, non-toggled state.
    abstract rootExpanded: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, enabled state
    abstract rootCheckedHovered: IStyle option with get, set
    /// Style override applied to the root on pressed in a checked, enabled state
    abstract rootCheckedPressed: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, disabled state
    abstract rootCheckedDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in a expanded state on hover
    abstract rootExpandedHovered: IStyle option with get, set
    /// Style for the flexbox container within the root element.
    abstract flexContainer: IStyle option with get, set
    /// Style for the text container within the flexbox container element (and contains the text and description).
    abstract textContainer: IStyle option with get, set
    /// Style for the icon on the near side of the label.
    abstract icon: IStyle option with get, set
    /// Style for the icon on the near side of the label on hover.
    abstract iconHovered: IStyle option with get, set
    /// Style for the icon on the near side of the label when pressed.
    abstract iconPressed: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded.
    abstract iconExpanded: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded and hovered.
    abstract iconExpandedHovered: IStyle option with get, set
    /// Style override for the icon when the button is disabled.
    abstract iconDisabled: IStyle option with get, set
    /// Style override for the icon when the button is checked.
    abstract iconChecked: IStyle option with get, set
    /// Style for the text content of the button.
    abstract label: IStyle option with get, set
    /// Style override for the text content when the button is disabled.
    abstract labelDisabled: IStyle option with get, set
    /// Style override for the text content when the button is checked.
    abstract labelChecked: IStyle option with get, set
    /// Style for the menu chevron.
    abstract menuIcon: IStyle option with get, set
    /// Style for the menu chevron on hover.
    abstract menuIconHovered: IStyle option with get, set
    /// Style for the menu chevron when pressed.
    abstract menuIconPressed: IStyle option with get, set
    /// Style for the menu chevron when expanded.
    abstract menuIconExpanded: IStyle option with get, set
    /// Style for the menu chevron when expanded and hovered.
    abstract menuIconExpandedHovered: IStyle option with get, set
    /// Style override for the menu chevron when the button is disabled.
    abstract menuIconDisabled: IStyle option with get, set
    /// Style override for the menu chevron when the button is checked.
    abstract menuIconChecked: IStyle option with get, set
    /// Style for the description text if applicable (for compound buttons.)
    abstract description: IStyle option with get, set
    /// Style override for the description text when the button is hovered.
    abstract descriptionHovered: IStyle option with get, set
    /// Style for the description text when the button is pressed.
    abstract descriptionPressed: IStyle option with get, set
    /// Style override for the description text when the button is disabled.
    abstract descriptionDisabled: IStyle option with get, set
    /// Style override for the description text when the button is checked.
    abstract descriptionChecked: IStyle option with get, set
    /// Style override for the screen reader text.
    abstract screenReaderText: IStyle option with get, set
    /// Style override for the container div around a SplitButton element
    abstract splitButtonContainer: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is hovered.
    abstract splitButtonContainerHovered: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is focused.
    abstract splitButtonContainerFocused: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked.
    abstract splitButtonContainerChecked: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked and hovered.
    abstract splitButtonContainerCheckedHovered: IStyle option with get, set
    /// Style override for the container div around a SplitButton element in a disabled state
    abstract splitButtonContainerDisabled: IStyle option with get, set
    /// Style override for the divider element that appears between the button and menu button
    /// for a split button.
    abstract splitButtonDivider: IStyle option with get, set
    /// Style override for the SplitButton menu button
    abstract splitButtonMenuButton: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a disabled state.
    abstract splitButtonMenuButtonDisabled: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a checked state
    abstract splitButtonMenuButtonChecked: IStyle option with get, set
    /// Style override for the SplitButton menu button element in an expanded state
    abstract splitButtonMenuButtonExpanded: IStyle option with get, set
    /// Style override for the SplitButton menu icon element
    abstract splitButtonMenuIcon: IStyle option with get, set
    /// Style override for the SplitButton menu icon element in a disabled state
    abstract splitButtonMenuIconDisabled: IStyle option with get, set
    /// Style override for the SplitButton FlexContainer.
    abstract splitButtonFlexContainer: IStyle option with get, set

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] Button =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] ButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IButtonProps -> Button

type [<AllowNullLiteral>] ActionButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] ActionButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ActionButton

type [<AllowNullLiteral>] CommandBarButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CommandBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CommandBarButton

type [<AllowNullLiteral>] CompoundButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CompoundButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CompoundButton

type [<AllowNullLiteral>] DefaultButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DefaultButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DefaultButton

type [<AllowNullLiteral>] MessageBarButton =
    inherit BaseComponent<IButtonProps, obj>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] MessageBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> MessageBarButton

type [<AllowNullLiteral>] PrimaryButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] PrimaryButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> PrimaryButton

type [<AllowNullLiteral>] IconButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] IconButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> IconButton
type BaseComponent = ______Utilities.BaseComponent
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IButtonProps = __Button_types.IButtonProps
type IButton = __Button_types.IButton
type BaseButton = __BaseButton.BaseButton
type Button = __Button.Button
type IButtonClassNames = __BaseButton_classNames.IButtonClassNames
type ISplitButtonClassNames = __SplitButton_SplitButton_classNames.ISplitButtonClassNames
type IRenderFunction = ______Utilities.IRenderFunction
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IIconProps = ______Icon.IIconProps
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type BaseComponent = ______Utilities.BaseComponent
type IButtonProps = __Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract BaseButton: BaseButtonStatic
    abstract Button: ButtonStatic
    abstract ActionButton: ActionButtonStatic
    abstract CommandBarButton: CommandBarButtonStatic
    abstract CompoundButton: CompoundButtonStatic
    abstract DefaultButton: DefaultButtonStatic
    abstract MessageBarButton: MessageBarButtonStatic
    abstract PrimaryButton: PrimaryButtonStatic
    abstract IconButton: IconButtonStatic

type [<AllowNullLiteral>] IBaseButtonProps =
    inherit IButtonProps
    abstract baseClassName: string option with get, set
    abstract variantClassName: string option with get, set

type [<AllowNullLiteral>] IBaseButtonState =
    abstract menuProps: IContextualMenuProps option option with get, set

type [<AllowNullLiteral>] BaseButton =
    inherit BaseComponent<IBaseButtonProps, IBaseButtonState>
    inherit IButton
    abstract _isSplitButton: obj
    abstract _isExpanded: obj
    abstract defaultProps: obj with get, set
    abstract _buttonElement: obj with get, set
    abstract _splitButtonContainer: obj with get, set
    abstract _labelId: obj with get, set
    abstract _descriptionId: obj with get, set
    abstract _ariaDescriptionId: obj with get, set
    abstract _classNames: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidUpdate: prevProps: IBaseButtonProps * prevState: IBaseButtonState -> unit
    abstract focus: unit -> unit
    abstract dismissMenu: unit -> unit
    abstract _onRenderContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderIcon: ?buttonProps: obj * ?defaultRender: obj -> unit
    abstract _onRenderTextContents: unit -> unit
    abstract _onRenderText: unit -> unit
    abstract _onRenderChildren: unit -> unit
    abstract _onRenderDescription: props: obj -> unit
    abstract _onRenderAriaDescription: unit -> unit
    abstract _onRenderMenuIcon: props: obj -> unit
    abstract _onRenderMenu: menuProps: obj -> unit
    abstract _dismissMenu: unit -> unit
    abstract _onToggleMenu: unit -> unit
    abstract _onRenderSplitButtonContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderSplitButtonDivider: classNames: obj -> unit
    abstract _onRenderSplitButtonMenuButton: classNames: obj -> unit
    abstract _onMouseDown: ev: obj -> unit
    abstract _onMenuKeyDown: ev: obj -> unit
    abstract _onMenuClick: ev: obj -> unit

type [<AllowNullLiteral>] BaseButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IBaseButtonProps * rootClassName: string -> BaseButton

type [<AllowNullLiteral>] IButton =
    /// Sets focus to the button.
    abstract focus: (unit -> unit) with get, set
    /// If there is a menu associated with this button and it is visible, this will dismiss the menu
    abstract dismissMenu: (unit -> unit) with get, set

type [<AllowNullLiteral>] IButtonProps =
    inherit React.AllHTMLAttributes<U4<HTMLAnchorElement, HTMLButtonElement, BaseButton, Button>>
    /// Optional callback to access the IButton interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IButton -> unit) option with get, set
    /// If provided, this component will be rendered as an anchor.
    abstract href: string option with get, set
    /// Changes the visual presentation of the button to be emphasized (if defined)
    abstract primary: bool option with get, set
    /// Unique id to identify the item. Typically a duplicate of key value.
    abstract uniqueId: U2<string, float> option with get, set
    /// Whether the button is disabled
    abstract disabled: bool option with get, set
    /// If set to true and if this is a splitButton (split == true) then the primary action of a split button is disabled.
    abstract primaryDisabled: bool option with get, set
    /// Custom styling for individual elements within the button DOM.
    abstract styles: IButtonStyles option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Whether the button is checked
    abstract ``checked``: bool option with get, set
    /// If provided, additional class name to provide on the root element.
    abstract className: string option with get, set
    /// The aria label of the button for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// Detailed description of the button for the benefit of screen readers.
    /// 
    /// Besides the compound button, other button types will need more information provided to screen reader.
    abstract ariaDescription: string option with get, set
    /// If provided and is true it adds an 'aria-hidden' attribute instructing screen readers to ignore the element.
    abstract ariaHidden: bool option with get, set
    /// Text to render button label. If text is supplied, it will override any string in button children. Other children components will be passed through after the text.
    abstract text: string option with get, set
    /// The props for the icon shown in the button.
    abstract iconProps: IIconProps option with get, set
    /// Props for button menu. Providing this will default to showing the menu icon. See menuIconProps for overriding
    /// how the default icon looks. Providing this in addition of onClick and setting the split property to true will render a SplitButton.
    abstract menuProps: IContextualMenuProps option with get, set
    /// Callback that runs after Button's contextualmenu was closed (removed from the DOM)
    abstract onAfterMenuDismiss: (unit -> unit) option with get, set
    /// If set to true, and if menuProps and onClick are provided, the button will render as a SplitButton. Defaults to false.
    abstract split: bool option with get, set
    /// The props for the icon shown when providing a menu dropdown.
    abstract menuIconProps: IIconProps option with get, set
    /// Accessible label for the dropdown chevron button if this button is split.
    abstract splitButtonAriaLabel: string option with get, set
    /// Optional callback when menu is clicked.
    abstract onMenuClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IButtonProps -> unit) option with get, set
    /// Custom render function for the icon
    abstract onRenderIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the label text.
    abstract onRenderText: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the desciption text.
    abstract onRenderDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the aria description element.
    abstract onRenderAriaDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for rendering the button children.
    abstract onRenderChildren: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu icon
    abstract onRenderMenuIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu
    abstract onRenderMenu: IRenderFunction<IContextualMenuProps> option with get, set
    /// Description of the action this button takes.
    /// Only used for compound buttons
    abstract description: string option with get, set
    /// Deprecated at v1.2.3, to be removed at >= v2.0.0. Use specific button component instead
    abstract buttonType: ButtonType option with get, set
    /// Deprecated at v0.56.2, to be removed at >= v1.0.0. Just pass in button props instead;
    /// they will be mixed into the button/anchor element rendered by the component.
    abstract rootProps: U2<React.ButtonHTMLAttributes<HTMLButtonElement>, React.AnchorHTMLAttributes<HTMLAnchorElement>> option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract toggled: bool option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract data: obj option option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getClassNames: (ITheme -> string -> string -> string option -> string option -> bool -> bool -> bool -> bool option -> IButtonClassNames) option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getSplitButtonClassNames: (bool -> bool -> bool -> ISplitButtonClassNames) option with get, set

type [<RequireQualifiedAccess>] ElementType =
    | Button = 0
    | Anchor = 1

type [<RequireQualifiedAccess>] ButtonType =
    | Normal = 0
    | Primary = 1
    | Hero = 2
    | Compound = 3
    | Command = 4
    | Icon = 5
    | Default = 6

type [<AllowNullLiteral>] IButtonStyles =
    /// Style for the root element in the default enabled, non-toggled state.
    abstract root: IStyle option with get, set
    /// Style override for the root element in a checked state, layered on top of the root style.
    abstract rootChecked: IStyle option with get, set
    /// Style override for the root element in a disabled state, layered on top of the root style.
    abstract rootDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootHovered: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootFocused: IStyle option with get, set
    /// Style override applied to the root on pressed in the default, enabled, non-toggled state.
    abstract rootPressed: IStyle option with get, set
    /// Style override applied to the root on when menu is expanded in the default, enabled, non-toggled state.
    abstract rootExpanded: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, enabled state
    abstract rootCheckedHovered: IStyle option with get, set
    /// Style override applied to the root on pressed in a checked, enabled state
    abstract rootCheckedPressed: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, disabled state
    abstract rootCheckedDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in a expanded state on hover
    abstract rootExpandedHovered: IStyle option with get, set
    /// Style for the flexbox container within the root element.
    abstract flexContainer: IStyle option with get, set
    /// Style for the text container within the flexbox container element (and contains the text and description).
    abstract textContainer: IStyle option with get, set
    /// Style for the icon on the near side of the label.
    abstract icon: IStyle option with get, set
    /// Style for the icon on the near side of the label on hover.
    abstract iconHovered: IStyle option with get, set
    /// Style for the icon on the near side of the label when pressed.
    abstract iconPressed: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded.
    abstract iconExpanded: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded and hovered.
    abstract iconExpandedHovered: IStyle option with get, set
    /// Style override for the icon when the button is disabled.
    abstract iconDisabled: IStyle option with get, set
    /// Style override for the icon when the button is checked.
    abstract iconChecked: IStyle option with get, set
    /// Style for the text content of the button.
    abstract label: IStyle option with get, set
    /// Style override for the text content when the button is disabled.
    abstract labelDisabled: IStyle option with get, set
    /// Style override for the text content when the button is checked.
    abstract labelChecked: IStyle option with get, set
    /// Style for the menu chevron.
    abstract menuIcon: IStyle option with get, set
    /// Style for the menu chevron on hover.
    abstract menuIconHovered: IStyle option with get, set
    /// Style for the menu chevron when pressed.
    abstract menuIconPressed: IStyle option with get, set
    /// Style for the menu chevron when expanded.
    abstract menuIconExpanded: IStyle option with get, set
    /// Style for the menu chevron when expanded and hovered.
    abstract menuIconExpandedHovered: IStyle option with get, set
    /// Style override for the menu chevron when the button is disabled.
    abstract menuIconDisabled: IStyle option with get, set
    /// Style override for the menu chevron when the button is checked.
    abstract menuIconChecked: IStyle option with get, set
    /// Style for the description text if applicable (for compound buttons.)
    abstract description: IStyle option with get, set
    /// Style override for the description text when the button is hovered.
    abstract descriptionHovered: IStyle option with get, set
    /// Style for the description text when the button is pressed.
    abstract descriptionPressed: IStyle option with get, set
    /// Style override for the description text when the button is disabled.
    abstract descriptionDisabled: IStyle option with get, set
    /// Style override for the description text when the button is checked.
    abstract descriptionChecked: IStyle option with get, set
    /// Style override for the screen reader text.
    abstract screenReaderText: IStyle option with get, set
    /// Style override for the container div around a SplitButton element
    abstract splitButtonContainer: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is hovered.
    abstract splitButtonContainerHovered: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is focused.
    abstract splitButtonContainerFocused: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked.
    abstract splitButtonContainerChecked: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked and hovered.
    abstract splitButtonContainerCheckedHovered: IStyle option with get, set
    /// Style override for the container div around a SplitButton element in a disabled state
    abstract splitButtonContainerDisabled: IStyle option with get, set
    /// Style override for the divider element that appears between the button and menu button
    /// for a split button.
    abstract splitButtonDivider: IStyle option with get, set
    /// Style override for the SplitButton menu button
    abstract splitButtonMenuButton: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a disabled state.
    abstract splitButtonMenuButtonDisabled: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a checked state
    abstract splitButtonMenuButtonChecked: IStyle option with get, set
    /// Style override for the SplitButton menu button element in an expanded state
    abstract splitButtonMenuButtonExpanded: IStyle option with get, set
    /// Style override for the SplitButton menu icon element
    abstract splitButtonMenuIcon: IStyle option with get, set
    /// Style override for the SplitButton menu icon element in a disabled state
    abstract splitButtonMenuIconDisabled: IStyle option with get, set
    /// Style override for the SplitButton FlexContainer.
    abstract splitButtonFlexContainer: IStyle option with get, set

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] Button =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] ButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IButtonProps -> Button

type [<AllowNullLiteral>] ActionButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] ActionButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ActionButton

type [<AllowNullLiteral>] CommandBarButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CommandBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CommandBarButton

type [<AllowNullLiteral>] CompoundButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CompoundButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CompoundButton

type [<AllowNullLiteral>] DefaultButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DefaultButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DefaultButton

type [<AllowNullLiteral>] MessageBarButton =
    inherit BaseComponent<IButtonProps, obj>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] MessageBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> MessageBarButton

type [<AllowNullLiteral>] PrimaryButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] PrimaryButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> PrimaryButton

type [<AllowNullLiteral>] IconButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] IconButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> IconButton
type BaseComponent = ______Utilities.BaseComponent
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IButtonProps = __Button_types.IButtonProps
type IButton = __Button_types.IButton
type BaseButton = __BaseButton.BaseButton
type Button = __Button.Button
type IButtonClassNames = __BaseButton_classNames.IButtonClassNames
type ISplitButtonClassNames = __SplitButton_SplitButton_classNames.ISplitButtonClassNames
type IRenderFunction = ______Utilities.IRenderFunction
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IIconProps = ______Icon.IIconProps
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type BaseComponent = ______Utilities.BaseComponent
type IButtonProps = __Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract BaseButton: BaseButtonStatic
    abstract Button: ButtonStatic
    abstract ActionButton: ActionButtonStatic
    abstract CommandBarButton: CommandBarButtonStatic
    abstract CompoundButton: CompoundButtonStatic
    abstract DefaultButton: DefaultButtonStatic
    abstract MessageBarButton: MessageBarButtonStatic
    abstract PrimaryButton: PrimaryButtonStatic
    abstract IconButton: IconButtonStatic

type [<AllowNullLiteral>] IBaseButtonProps =
    inherit IButtonProps
    abstract baseClassName: string option with get, set
    abstract variantClassName: string option with get, set

type [<AllowNullLiteral>] IBaseButtonState =
    abstract menuProps: IContextualMenuProps option option with get, set

type [<AllowNullLiteral>] BaseButton =
    inherit BaseComponent<IBaseButtonProps, IBaseButtonState>
    inherit IButton
    abstract _isSplitButton: obj
    abstract _isExpanded: obj
    abstract defaultProps: obj with get, set
    abstract _buttonElement: obj with get, set
    abstract _splitButtonContainer: obj with get, set
    abstract _labelId: obj with get, set
    abstract _descriptionId: obj with get, set
    abstract _ariaDescriptionId: obj with get, set
    abstract _classNames: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidUpdate: prevProps: IBaseButtonProps * prevState: IBaseButtonState -> unit
    abstract focus: unit -> unit
    abstract dismissMenu: unit -> unit
    abstract _onRenderContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderIcon: ?buttonProps: obj * ?defaultRender: obj -> unit
    abstract _onRenderTextContents: unit -> unit
    abstract _onRenderText: unit -> unit
    abstract _onRenderChildren: unit -> unit
    abstract _onRenderDescription: props: obj -> unit
    abstract _onRenderAriaDescription: unit -> unit
    abstract _onRenderMenuIcon: props: obj -> unit
    abstract _onRenderMenu: menuProps: obj -> unit
    abstract _dismissMenu: unit -> unit
    abstract _onToggleMenu: unit -> unit
    abstract _onRenderSplitButtonContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderSplitButtonDivider: classNames: obj -> unit
    abstract _onRenderSplitButtonMenuButton: classNames: obj -> unit
    abstract _onMouseDown: ev: obj -> unit
    abstract _onMenuKeyDown: ev: obj -> unit
    abstract _onMenuClick: ev: obj -> unit

type [<AllowNullLiteral>] BaseButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IBaseButtonProps * rootClassName: string -> BaseButton

type [<AllowNullLiteral>] IButton =
    /// Sets focus to the button.
    abstract focus: (unit -> unit) with get, set
    /// If there is a menu associated with this button and it is visible, this will dismiss the menu
    abstract dismissMenu: (unit -> unit) with get, set

type [<AllowNullLiteral>] IButtonProps =
    inherit React.AllHTMLAttributes<U4<HTMLAnchorElement, HTMLButtonElement, BaseButton, Button>>
    /// Optional callback to access the IButton interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IButton -> unit) option with get, set
    /// If provided, this component will be rendered as an anchor.
    abstract href: string option with get, set
    /// Changes the visual presentation of the button to be emphasized (if defined)
    abstract primary: bool option with get, set
    /// Unique id to identify the item. Typically a duplicate of key value.
    abstract uniqueId: U2<string, float> option with get, set
    /// Whether the button is disabled
    abstract disabled: bool option with get, set
    /// If set to true and if this is a splitButton (split == true) then the primary action of a split button is disabled.
    abstract primaryDisabled: bool option with get, set
    /// Custom styling for individual elements within the button DOM.
    abstract styles: IButtonStyles option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Whether the button is checked
    abstract ``checked``: bool option with get, set
    /// If provided, additional class name to provide on the root element.
    abstract className: string option with get, set
    /// The aria label of the button for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// Detailed description of the button for the benefit of screen readers.
    /// 
    /// Besides the compound button, other button types will need more information provided to screen reader.
    abstract ariaDescription: string option with get, set
    /// If provided and is true it adds an 'aria-hidden' attribute instructing screen readers to ignore the element.
    abstract ariaHidden: bool option with get, set
    /// Text to render button label. If text is supplied, it will override any string in button children. Other children components will be passed through after the text.
    abstract text: string option with get, set
    /// The props for the icon shown in the button.
    abstract iconProps: IIconProps option with get, set
    /// Props for button menu. Providing this will default to showing the menu icon. See menuIconProps for overriding
    /// how the default icon looks. Providing this in addition of onClick and setting the split property to true will render a SplitButton.
    abstract menuProps: IContextualMenuProps option with get, set
    /// Callback that runs after Button's contextualmenu was closed (removed from the DOM)
    abstract onAfterMenuDismiss: (unit -> unit) option with get, set
    /// If set to true, and if menuProps and onClick are provided, the button will render as a SplitButton. Defaults to false.
    abstract split: bool option with get, set
    /// The props for the icon shown when providing a menu dropdown.
    abstract menuIconProps: IIconProps option with get, set
    /// Accessible label for the dropdown chevron button if this button is split.
    abstract splitButtonAriaLabel: string option with get, set
    /// Optional callback when menu is clicked.
    abstract onMenuClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IButtonProps -> unit) option with get, set
    /// Custom render function for the icon
    abstract onRenderIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the label text.
    abstract onRenderText: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the desciption text.
    abstract onRenderDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the aria description element.
    abstract onRenderAriaDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for rendering the button children.
    abstract onRenderChildren: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu icon
    abstract onRenderMenuIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu
    abstract onRenderMenu: IRenderFunction<IContextualMenuProps> option with get, set
    /// Description of the action this button takes.
    /// Only used for compound buttons
    abstract description: string option with get, set
    /// Deprecated at v1.2.3, to be removed at >= v2.0.0. Use specific button component instead
    abstract buttonType: ButtonType option with get, set
    /// Deprecated at v0.56.2, to be removed at >= v1.0.0. Just pass in button props instead;
    /// they will be mixed into the button/anchor element rendered by the component.
    abstract rootProps: U2<React.ButtonHTMLAttributes<HTMLButtonElement>, React.AnchorHTMLAttributes<HTMLAnchorElement>> option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract toggled: bool option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract data: obj option option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getClassNames: (ITheme -> string -> string -> string option -> string option -> bool -> bool -> bool -> bool option -> IButtonClassNames) option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getSplitButtonClassNames: (bool -> bool -> bool -> ISplitButtonClassNames) option with get, set

type [<RequireQualifiedAccess>] ElementType =
    | Button = 0
    | Anchor = 1

type [<RequireQualifiedAccess>] ButtonType =
    | Normal = 0
    | Primary = 1
    | Hero = 2
    | Compound = 3
    | Command = 4
    | Icon = 5
    | Default = 6

type [<AllowNullLiteral>] IButtonStyles =
    /// Style for the root element in the default enabled, non-toggled state.
    abstract root: IStyle option with get, set
    /// Style override for the root element in a checked state, layered on top of the root style.
    abstract rootChecked: IStyle option with get, set
    /// Style override for the root element in a disabled state, layered on top of the root style.
    abstract rootDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootHovered: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootFocused: IStyle option with get, set
    /// Style override applied to the root on pressed in the default, enabled, non-toggled state.
    abstract rootPressed: IStyle option with get, set
    /// Style override applied to the root on when menu is expanded in the default, enabled, non-toggled state.
    abstract rootExpanded: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, enabled state
    abstract rootCheckedHovered: IStyle option with get, set
    /// Style override applied to the root on pressed in a checked, enabled state
    abstract rootCheckedPressed: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, disabled state
    abstract rootCheckedDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in a expanded state on hover
    abstract rootExpandedHovered: IStyle option with get, set
    /// Style for the flexbox container within the root element.
    abstract flexContainer: IStyle option with get, set
    /// Style for the text container within the flexbox container element (and contains the text and description).
    abstract textContainer: IStyle option with get, set
    /// Style for the icon on the near side of the label.
    abstract icon: IStyle option with get, set
    /// Style for the icon on the near side of the label on hover.
    abstract iconHovered: IStyle option with get, set
    /// Style for the icon on the near side of the label when pressed.
    abstract iconPressed: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded.
    abstract iconExpanded: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded and hovered.
    abstract iconExpandedHovered: IStyle option with get, set
    /// Style override for the icon when the button is disabled.
    abstract iconDisabled: IStyle option with get, set
    /// Style override for the icon when the button is checked.
    abstract iconChecked: IStyle option with get, set
    /// Style for the text content of the button.
    abstract label: IStyle option with get, set
    /// Style override for the text content when the button is disabled.
    abstract labelDisabled: IStyle option with get, set
    /// Style override for the text content when the button is checked.
    abstract labelChecked: IStyle option with get, set
    /// Style for the menu chevron.
    abstract menuIcon: IStyle option with get, set
    /// Style for the menu chevron on hover.
    abstract menuIconHovered: IStyle option with get, set
    /// Style for the menu chevron when pressed.
    abstract menuIconPressed: IStyle option with get, set
    /// Style for the menu chevron when expanded.
    abstract menuIconExpanded: IStyle option with get, set
    /// Style for the menu chevron when expanded and hovered.
    abstract menuIconExpandedHovered: IStyle option with get, set
    /// Style override for the menu chevron when the button is disabled.
    abstract menuIconDisabled: IStyle option with get, set
    /// Style override for the menu chevron when the button is checked.
    abstract menuIconChecked: IStyle option with get, set
    /// Style for the description text if applicable (for compound buttons.)
    abstract description: IStyle option with get, set
    /// Style override for the description text when the button is hovered.
    abstract descriptionHovered: IStyle option with get, set
    /// Style for the description text when the button is pressed.
    abstract descriptionPressed: IStyle option with get, set
    /// Style override for the description text when the button is disabled.
    abstract descriptionDisabled: IStyle option with get, set
    /// Style override for the description text when the button is checked.
    abstract descriptionChecked: IStyle option with get, set
    /// Style override for the screen reader text.
    abstract screenReaderText: IStyle option with get, set
    /// Style override for the container div around a SplitButton element
    abstract splitButtonContainer: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is hovered.
    abstract splitButtonContainerHovered: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is focused.
    abstract splitButtonContainerFocused: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked.
    abstract splitButtonContainerChecked: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked and hovered.
    abstract splitButtonContainerCheckedHovered: IStyle option with get, set
    /// Style override for the container div around a SplitButton element in a disabled state
    abstract splitButtonContainerDisabled: IStyle option with get, set
    /// Style override for the divider element that appears between the button and menu button
    /// for a split button.
    abstract splitButtonDivider: IStyle option with get, set
    /// Style override for the SplitButton menu button
    abstract splitButtonMenuButton: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a disabled state.
    abstract splitButtonMenuButtonDisabled: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a checked state
    abstract splitButtonMenuButtonChecked: IStyle option with get, set
    /// Style override for the SplitButton menu button element in an expanded state
    abstract splitButtonMenuButtonExpanded: IStyle option with get, set
    /// Style override for the SplitButton menu icon element
    abstract splitButtonMenuIcon: IStyle option with get, set
    /// Style override for the SplitButton menu icon element in a disabled state
    abstract splitButtonMenuIconDisabled: IStyle option with get, set
    /// Style override for the SplitButton FlexContainer.
    abstract splitButtonFlexContainer: IStyle option with get, set

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] Button =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] ButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IButtonProps -> Button

type [<AllowNullLiteral>] ActionButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] ActionButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ActionButton

type [<AllowNullLiteral>] CommandBarButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CommandBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CommandBarButton

type [<AllowNullLiteral>] CompoundButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CompoundButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CompoundButton

type [<AllowNullLiteral>] DefaultButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DefaultButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DefaultButton

type [<AllowNullLiteral>] MessageBarButton =
    inherit BaseComponent<IButtonProps, obj>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] MessageBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> MessageBarButton

type [<AllowNullLiteral>] PrimaryButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] PrimaryButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> PrimaryButton

type [<AllowNullLiteral>] IconButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] IconButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> IconButton
type BaseComponent = ______Utilities.BaseComponent
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IButtonProps = __Button_types.IButtonProps
type IButton = __Button_types.IButton
type BaseButton = __BaseButton.BaseButton
type Button = __Button.Button
type IButtonClassNames = __BaseButton_classNames.IButtonClassNames
type ISplitButtonClassNames = __SplitButton_SplitButton_classNames.ISplitButtonClassNames
type IRenderFunction = ______Utilities.IRenderFunction
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IIconProps = ______Icon.IIconProps
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type BaseComponent = ______Utilities.BaseComponent
type IButtonProps = __Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract BaseButton: BaseButtonStatic
    abstract Button: ButtonStatic
    abstract ActionButton: ActionButtonStatic
    abstract CommandBarButton: CommandBarButtonStatic
    abstract CompoundButton: CompoundButtonStatic
    abstract DefaultButton: DefaultButtonStatic
    abstract MessageBarButton: MessageBarButtonStatic
    abstract PrimaryButton: PrimaryButtonStatic
    abstract IconButton: IconButtonStatic

type [<AllowNullLiteral>] IBaseButtonProps =
    inherit IButtonProps
    abstract baseClassName: string option with get, set
    abstract variantClassName: string option with get, set

type [<AllowNullLiteral>] IBaseButtonState =
    abstract menuProps: IContextualMenuProps option option with get, set

type [<AllowNullLiteral>] BaseButton =
    inherit BaseComponent<IBaseButtonProps, IBaseButtonState>
    inherit IButton
    abstract _isSplitButton: obj
    abstract _isExpanded: obj
    abstract defaultProps: obj with get, set
    abstract _buttonElement: obj with get, set
    abstract _splitButtonContainer: obj with get, set
    abstract _labelId: obj with get, set
    abstract _descriptionId: obj with get, set
    abstract _ariaDescriptionId: obj with get, set
    abstract _classNames: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidUpdate: prevProps: IBaseButtonProps * prevState: IBaseButtonState -> unit
    abstract focus: unit -> unit
    abstract dismissMenu: unit -> unit
    abstract _onRenderContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderIcon: ?buttonProps: obj * ?defaultRender: obj -> unit
    abstract _onRenderTextContents: unit -> unit
    abstract _onRenderText: unit -> unit
    abstract _onRenderChildren: unit -> unit
    abstract _onRenderDescription: props: obj -> unit
    abstract _onRenderAriaDescription: unit -> unit
    abstract _onRenderMenuIcon: props: obj -> unit
    abstract _onRenderMenu: menuProps: obj -> unit
    abstract _dismissMenu: unit -> unit
    abstract _onToggleMenu: unit -> unit
    abstract _onRenderSplitButtonContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderSplitButtonDivider: classNames: obj -> unit
    abstract _onRenderSplitButtonMenuButton: classNames: obj -> unit
    abstract _onMouseDown: ev: obj -> unit
    abstract _onMenuKeyDown: ev: obj -> unit
    abstract _onMenuClick: ev: obj -> unit

type [<AllowNullLiteral>] BaseButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IBaseButtonProps * rootClassName: string -> BaseButton

type [<AllowNullLiteral>] IButton =
    /// Sets focus to the button.
    abstract focus: (unit -> unit) with get, set
    /// If there is a menu associated with this button and it is visible, this will dismiss the menu
    abstract dismissMenu: (unit -> unit) with get, set

type [<AllowNullLiteral>] IButtonProps =
    inherit React.AllHTMLAttributes<U4<HTMLAnchorElement, HTMLButtonElement, BaseButton, Button>>
    /// Optional callback to access the IButton interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IButton -> unit) option with get, set
    /// If provided, this component will be rendered as an anchor.
    abstract href: string option with get, set
    /// Changes the visual presentation of the button to be emphasized (if defined)
    abstract primary: bool option with get, set
    /// Unique id to identify the item. Typically a duplicate of key value.
    abstract uniqueId: U2<string, float> option with get, set
    /// Whether the button is disabled
    abstract disabled: bool option with get, set
    /// If set to true and if this is a splitButton (split == true) then the primary action of a split button is disabled.
    abstract primaryDisabled: bool option with get, set
    /// Custom styling for individual elements within the button DOM.
    abstract styles: IButtonStyles option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Whether the button is checked
    abstract ``checked``: bool option with get, set
    /// If provided, additional class name to provide on the root element.
    abstract className: string option with get, set
    /// The aria label of the button for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// Detailed description of the button for the benefit of screen readers.
    /// 
    /// Besides the compound button, other button types will need more information provided to screen reader.
    abstract ariaDescription: string option with get, set
    /// If provided and is true it adds an 'aria-hidden' attribute instructing screen readers to ignore the element.
    abstract ariaHidden: bool option with get, set
    /// Text to render button label. If text is supplied, it will override any string in button children. Other children components will be passed through after the text.
    abstract text: string option with get, set
    /// The props for the icon shown in the button.
    abstract iconProps: IIconProps option with get, set
    /// Props for button menu. Providing this will default to showing the menu icon. See menuIconProps for overriding
    /// how the default icon looks. Providing this in addition of onClick and setting the split property to true will render a SplitButton.
    abstract menuProps: IContextualMenuProps option with get, set
    /// Callback that runs after Button's contextualmenu was closed (removed from the DOM)
    abstract onAfterMenuDismiss: (unit -> unit) option with get, set
    /// If set to true, and if menuProps and onClick are provided, the button will render as a SplitButton. Defaults to false.
    abstract split: bool option with get, set
    /// The props for the icon shown when providing a menu dropdown.
    abstract menuIconProps: IIconProps option with get, set
    /// Accessible label for the dropdown chevron button if this button is split.
    abstract splitButtonAriaLabel: string option with get, set
    /// Optional callback when menu is clicked.
    abstract onMenuClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IButtonProps -> unit) option with get, set
    /// Custom render function for the icon
    abstract onRenderIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the label text.
    abstract onRenderText: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the desciption text.
    abstract onRenderDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the aria description element.
    abstract onRenderAriaDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for rendering the button children.
    abstract onRenderChildren: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu icon
    abstract onRenderMenuIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu
    abstract onRenderMenu: IRenderFunction<IContextualMenuProps> option with get, set
    /// Description of the action this button takes.
    /// Only used for compound buttons
    abstract description: string option with get, set
    /// Deprecated at v1.2.3, to be removed at >= v2.0.0. Use specific button component instead
    abstract buttonType: ButtonType option with get, set
    /// Deprecated at v0.56.2, to be removed at >= v1.0.0. Just pass in button props instead;
    /// they will be mixed into the button/anchor element rendered by the component.
    abstract rootProps: U2<React.ButtonHTMLAttributes<HTMLButtonElement>, React.AnchorHTMLAttributes<HTMLAnchorElement>> option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract toggled: bool option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract data: obj option option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getClassNames: (ITheme -> string -> string -> string option -> string option -> bool -> bool -> bool -> bool option -> IButtonClassNames) option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getSplitButtonClassNames: (bool -> bool -> bool -> ISplitButtonClassNames) option with get, set

type [<RequireQualifiedAccess>] ElementType =
    | Button = 0
    | Anchor = 1

type [<RequireQualifiedAccess>] ButtonType =
    | Normal = 0
    | Primary = 1
    | Hero = 2
    | Compound = 3
    | Command = 4
    | Icon = 5
    | Default = 6

type [<AllowNullLiteral>] IButtonStyles =
    /// Style for the root element in the default enabled, non-toggled state.
    abstract root: IStyle option with get, set
    /// Style override for the root element in a checked state, layered on top of the root style.
    abstract rootChecked: IStyle option with get, set
    /// Style override for the root element in a disabled state, layered on top of the root style.
    abstract rootDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootHovered: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootFocused: IStyle option with get, set
    /// Style override applied to the root on pressed in the default, enabled, non-toggled state.
    abstract rootPressed: IStyle option with get, set
    /// Style override applied to the root on when menu is expanded in the default, enabled, non-toggled state.
    abstract rootExpanded: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, enabled state
    abstract rootCheckedHovered: IStyle option with get, set
    /// Style override applied to the root on pressed in a checked, enabled state
    abstract rootCheckedPressed: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, disabled state
    abstract rootCheckedDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in a expanded state on hover
    abstract rootExpandedHovered: IStyle option with get, set
    /// Style for the flexbox container within the root element.
    abstract flexContainer: IStyle option with get, set
    /// Style for the text container within the flexbox container element (and contains the text and description).
    abstract textContainer: IStyle option with get, set
    /// Style for the icon on the near side of the label.
    abstract icon: IStyle option with get, set
    /// Style for the icon on the near side of the label on hover.
    abstract iconHovered: IStyle option with get, set
    /// Style for the icon on the near side of the label when pressed.
    abstract iconPressed: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded.
    abstract iconExpanded: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded and hovered.
    abstract iconExpandedHovered: IStyle option with get, set
    /// Style override for the icon when the button is disabled.
    abstract iconDisabled: IStyle option with get, set
    /// Style override for the icon when the button is checked.
    abstract iconChecked: IStyle option with get, set
    /// Style for the text content of the button.
    abstract label: IStyle option with get, set
    /// Style override for the text content when the button is disabled.
    abstract labelDisabled: IStyle option with get, set
    /// Style override for the text content when the button is checked.
    abstract labelChecked: IStyle option with get, set
    /// Style for the menu chevron.
    abstract menuIcon: IStyle option with get, set
    /// Style for the menu chevron on hover.
    abstract menuIconHovered: IStyle option with get, set
    /// Style for the menu chevron when pressed.
    abstract menuIconPressed: IStyle option with get, set
    /// Style for the menu chevron when expanded.
    abstract menuIconExpanded: IStyle option with get, set
    /// Style for the menu chevron when expanded and hovered.
    abstract menuIconExpandedHovered: IStyle option with get, set
    /// Style override for the menu chevron when the button is disabled.
    abstract menuIconDisabled: IStyle option with get, set
    /// Style override for the menu chevron when the button is checked.
    abstract menuIconChecked: IStyle option with get, set
    /// Style for the description text if applicable (for compound buttons.)
    abstract description: IStyle option with get, set
    /// Style override for the description text when the button is hovered.
    abstract descriptionHovered: IStyle option with get, set
    /// Style for the description text when the button is pressed.
    abstract descriptionPressed: IStyle option with get, set
    /// Style override for the description text when the button is disabled.
    abstract descriptionDisabled: IStyle option with get, set
    /// Style override for the description text when the button is checked.
    abstract descriptionChecked: IStyle option with get, set
    /// Style override for the screen reader text.
    abstract screenReaderText: IStyle option with get, set
    /// Style override for the container div around a SplitButton element
    abstract splitButtonContainer: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is hovered.
    abstract splitButtonContainerHovered: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is focused.
    abstract splitButtonContainerFocused: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked.
    abstract splitButtonContainerChecked: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked and hovered.
    abstract splitButtonContainerCheckedHovered: IStyle option with get, set
    /// Style override for the container div around a SplitButton element in a disabled state
    abstract splitButtonContainerDisabled: IStyle option with get, set
    /// Style override for the divider element that appears between the button and menu button
    /// for a split button.
    abstract splitButtonDivider: IStyle option with get, set
    /// Style override for the SplitButton menu button
    abstract splitButtonMenuButton: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a disabled state.
    abstract splitButtonMenuButtonDisabled: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a checked state
    abstract splitButtonMenuButtonChecked: IStyle option with get, set
    /// Style override for the SplitButton menu button element in an expanded state
    abstract splitButtonMenuButtonExpanded: IStyle option with get, set
    /// Style override for the SplitButton menu icon element
    abstract splitButtonMenuIcon: IStyle option with get, set
    /// Style override for the SplitButton menu icon element in a disabled state
    abstract splitButtonMenuIconDisabled: IStyle option with get, set
    /// Style override for the SplitButton FlexContainer.
    abstract splitButtonFlexContainer: IStyle option with get, set

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] Button =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] ButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IButtonProps -> Button

type [<AllowNullLiteral>] ActionButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] ActionButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ActionButton

type [<AllowNullLiteral>] CommandBarButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CommandBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CommandBarButton

type [<AllowNullLiteral>] CompoundButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CompoundButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CompoundButton

type [<AllowNullLiteral>] DefaultButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DefaultButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DefaultButton

type [<AllowNullLiteral>] MessageBarButton =
    inherit BaseComponent<IButtonProps, obj>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] MessageBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> MessageBarButton

type [<AllowNullLiteral>] PrimaryButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] PrimaryButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> PrimaryButton

type [<AllowNullLiteral>] IconButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] IconButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> IconButton
type BaseComponent = ______Utilities.BaseComponent
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IButtonProps = __Button_types.IButtonProps
type IButton = __Button_types.IButton
type BaseButton = __BaseButton.BaseButton
type Button = __Button.Button
type IButtonClassNames = __BaseButton_classNames.IButtonClassNames
type ISplitButtonClassNames = __SplitButton_SplitButton_classNames.ISplitButtonClassNames
type IRenderFunction = ______Utilities.IRenderFunction
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IIconProps = ______Icon.IIconProps
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type BaseComponent = ______Utilities.BaseComponent
type IButtonProps = __Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract BaseButton: BaseButtonStatic
    abstract Button: ButtonStatic
    abstract ActionButton: ActionButtonStatic
    abstract CommandBarButton: CommandBarButtonStatic
    abstract CompoundButton: CompoundButtonStatic
    abstract DefaultButton: DefaultButtonStatic
    abstract MessageBarButton: MessageBarButtonStatic
    abstract PrimaryButton: PrimaryButtonStatic
    abstract IconButton: IconButtonStatic

type [<AllowNullLiteral>] IBaseButtonProps =
    inherit IButtonProps
    abstract baseClassName: string option with get, set
    abstract variantClassName: string option with get, set

type [<AllowNullLiteral>] IBaseButtonState =
    abstract menuProps: IContextualMenuProps option option with get, set

type [<AllowNullLiteral>] BaseButton =
    inherit BaseComponent<IBaseButtonProps, IBaseButtonState>
    inherit IButton
    abstract _isSplitButton: obj
    abstract _isExpanded: obj
    abstract defaultProps: obj with get, set
    abstract _buttonElement: obj with get, set
    abstract _splitButtonContainer: obj with get, set
    abstract _labelId: obj with get, set
    abstract _descriptionId: obj with get, set
    abstract _ariaDescriptionId: obj with get, set
    abstract _classNames: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidUpdate: prevProps: IBaseButtonProps * prevState: IBaseButtonState -> unit
    abstract focus: unit -> unit
    abstract dismissMenu: unit -> unit
    abstract _onRenderContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderIcon: ?buttonProps: obj * ?defaultRender: obj -> unit
    abstract _onRenderTextContents: unit -> unit
    abstract _onRenderText: unit -> unit
    abstract _onRenderChildren: unit -> unit
    abstract _onRenderDescription: props: obj -> unit
    abstract _onRenderAriaDescription: unit -> unit
    abstract _onRenderMenuIcon: props: obj -> unit
    abstract _onRenderMenu: menuProps: obj -> unit
    abstract _dismissMenu: unit -> unit
    abstract _onToggleMenu: unit -> unit
    abstract _onRenderSplitButtonContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderSplitButtonDivider: classNames: obj -> unit
    abstract _onRenderSplitButtonMenuButton: classNames: obj -> unit
    abstract _onMouseDown: ev: obj -> unit
    abstract _onMenuKeyDown: ev: obj -> unit
    abstract _onMenuClick: ev: obj -> unit

type [<AllowNullLiteral>] BaseButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IBaseButtonProps * rootClassName: string -> BaseButton

type [<AllowNullLiteral>] IButton =
    /// Sets focus to the button.
    abstract focus: (unit -> unit) with get, set
    /// If there is a menu associated with this button and it is visible, this will dismiss the menu
    abstract dismissMenu: (unit -> unit) with get, set

type [<AllowNullLiteral>] IButtonProps =
    inherit React.AllHTMLAttributes<U4<HTMLAnchorElement, HTMLButtonElement, BaseButton, Button>>
    /// Optional callback to access the IButton interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IButton -> unit) option with get, set
    /// If provided, this component will be rendered as an anchor.
    abstract href: string option with get, set
    /// Changes the visual presentation of the button to be emphasized (if defined)
    abstract primary: bool option with get, set
    /// Unique id to identify the item. Typically a duplicate of key value.
    abstract uniqueId: U2<string, float> option with get, set
    /// Whether the button is disabled
    abstract disabled: bool option with get, set
    /// If set to true and if this is a splitButton (split == true) then the primary action of a split button is disabled.
    abstract primaryDisabled: bool option with get, set
    /// Custom styling for individual elements within the button DOM.
    abstract styles: IButtonStyles option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Whether the button is checked
    abstract ``checked``: bool option with get, set
    /// If provided, additional class name to provide on the root element.
    abstract className: string option with get, set
    /// The aria label of the button for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// Detailed description of the button for the benefit of screen readers.
    /// 
    /// Besides the compound button, other button types will need more information provided to screen reader.
    abstract ariaDescription: string option with get, set
    /// If provided and is true it adds an 'aria-hidden' attribute instructing screen readers to ignore the element.
    abstract ariaHidden: bool option with get, set
    /// Text to render button label. If text is supplied, it will override any string in button children. Other children components will be passed through after the text.
    abstract text: string option with get, set
    /// The props for the icon shown in the button.
    abstract iconProps: IIconProps option with get, set
    /// Props for button menu. Providing this will default to showing the menu icon. See menuIconProps for overriding
    /// how the default icon looks. Providing this in addition of onClick and setting the split property to true will render a SplitButton.
    abstract menuProps: IContextualMenuProps option with get, set
    /// Callback that runs after Button's contextualmenu was closed (removed from the DOM)
    abstract onAfterMenuDismiss: (unit -> unit) option with get, set
    /// If set to true, and if menuProps and onClick are provided, the button will render as a SplitButton. Defaults to false.
    abstract split: bool option with get, set
    /// The props for the icon shown when providing a menu dropdown.
    abstract menuIconProps: IIconProps option with get, set
    /// Accessible label for the dropdown chevron button if this button is split.
    abstract splitButtonAriaLabel: string option with get, set
    /// Optional callback when menu is clicked.
    abstract onMenuClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IButtonProps -> unit) option with get, set
    /// Custom render function for the icon
    abstract onRenderIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the label text.
    abstract onRenderText: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the desciption text.
    abstract onRenderDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the aria description element.
    abstract onRenderAriaDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for rendering the button children.
    abstract onRenderChildren: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu icon
    abstract onRenderMenuIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu
    abstract onRenderMenu: IRenderFunction<IContextualMenuProps> option with get, set
    /// Description of the action this button takes.
    /// Only used for compound buttons
    abstract description: string option with get, set
    /// Deprecated at v1.2.3, to be removed at >= v2.0.0. Use specific button component instead
    abstract buttonType: ButtonType option with get, set
    /// Deprecated at v0.56.2, to be removed at >= v1.0.0. Just pass in button props instead;
    /// they will be mixed into the button/anchor element rendered by the component.
    abstract rootProps: U2<React.ButtonHTMLAttributes<HTMLButtonElement>, React.AnchorHTMLAttributes<HTMLAnchorElement>> option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract toggled: bool option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract data: obj option option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getClassNames: (ITheme -> string -> string -> string option -> string option -> bool -> bool -> bool -> bool option -> IButtonClassNames) option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getSplitButtonClassNames: (bool -> bool -> bool -> ISplitButtonClassNames) option with get, set

type [<RequireQualifiedAccess>] ElementType =
    | Button = 0
    | Anchor = 1

type [<RequireQualifiedAccess>] ButtonType =
    | Normal = 0
    | Primary = 1
    | Hero = 2
    | Compound = 3
    | Command = 4
    | Icon = 5
    | Default = 6

type [<AllowNullLiteral>] IButtonStyles =
    /// Style for the root element in the default enabled, non-toggled state.
    abstract root: IStyle option with get, set
    /// Style override for the root element in a checked state, layered on top of the root style.
    abstract rootChecked: IStyle option with get, set
    /// Style override for the root element in a disabled state, layered on top of the root style.
    abstract rootDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootHovered: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootFocused: IStyle option with get, set
    /// Style override applied to the root on pressed in the default, enabled, non-toggled state.
    abstract rootPressed: IStyle option with get, set
    /// Style override applied to the root on when menu is expanded in the default, enabled, non-toggled state.
    abstract rootExpanded: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, enabled state
    abstract rootCheckedHovered: IStyle option with get, set
    /// Style override applied to the root on pressed in a checked, enabled state
    abstract rootCheckedPressed: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, disabled state
    abstract rootCheckedDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in a expanded state on hover
    abstract rootExpandedHovered: IStyle option with get, set
    /// Style for the flexbox container within the root element.
    abstract flexContainer: IStyle option with get, set
    /// Style for the text container within the flexbox container element (and contains the text and description).
    abstract textContainer: IStyle option with get, set
    /// Style for the icon on the near side of the label.
    abstract icon: IStyle option with get, set
    /// Style for the icon on the near side of the label on hover.
    abstract iconHovered: IStyle option with get, set
    /// Style for the icon on the near side of the label when pressed.
    abstract iconPressed: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded.
    abstract iconExpanded: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded and hovered.
    abstract iconExpandedHovered: IStyle option with get, set
    /// Style override for the icon when the button is disabled.
    abstract iconDisabled: IStyle option with get, set
    /// Style override for the icon when the button is checked.
    abstract iconChecked: IStyle option with get, set
    /// Style for the text content of the button.
    abstract label: IStyle option with get, set
    /// Style override for the text content when the button is disabled.
    abstract labelDisabled: IStyle option with get, set
    /// Style override for the text content when the button is checked.
    abstract labelChecked: IStyle option with get, set
    /// Style for the menu chevron.
    abstract menuIcon: IStyle option with get, set
    /// Style for the menu chevron on hover.
    abstract menuIconHovered: IStyle option with get, set
    /// Style for the menu chevron when pressed.
    abstract menuIconPressed: IStyle option with get, set
    /// Style for the menu chevron when expanded.
    abstract menuIconExpanded: IStyle option with get, set
    /// Style for the menu chevron when expanded and hovered.
    abstract menuIconExpandedHovered: IStyle option with get, set
    /// Style override for the menu chevron when the button is disabled.
    abstract menuIconDisabled: IStyle option with get, set
    /// Style override for the menu chevron when the button is checked.
    abstract menuIconChecked: IStyle option with get, set
    /// Style for the description text if applicable (for compound buttons.)
    abstract description: IStyle option with get, set
    /// Style override for the description text when the button is hovered.
    abstract descriptionHovered: IStyle option with get, set
    /// Style for the description text when the button is pressed.
    abstract descriptionPressed: IStyle option with get, set
    /// Style override for the description text when the button is disabled.
    abstract descriptionDisabled: IStyle option with get, set
    /// Style override for the description text when the button is checked.
    abstract descriptionChecked: IStyle option with get, set
    /// Style override for the screen reader text.
    abstract screenReaderText: IStyle option with get, set
    /// Style override for the container div around a SplitButton element
    abstract splitButtonContainer: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is hovered.
    abstract splitButtonContainerHovered: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is focused.
    abstract splitButtonContainerFocused: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked.
    abstract splitButtonContainerChecked: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked and hovered.
    abstract splitButtonContainerCheckedHovered: IStyle option with get, set
    /// Style override for the container div around a SplitButton element in a disabled state
    abstract splitButtonContainerDisabled: IStyle option with get, set
    /// Style override for the divider element that appears between the button and menu button
    /// for a split button.
    abstract splitButtonDivider: IStyle option with get, set
    /// Style override for the SplitButton menu button
    abstract splitButtonMenuButton: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a disabled state.
    abstract splitButtonMenuButtonDisabled: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a checked state
    abstract splitButtonMenuButtonChecked: IStyle option with get, set
    /// Style override for the SplitButton menu button element in an expanded state
    abstract splitButtonMenuButtonExpanded: IStyle option with get, set
    /// Style override for the SplitButton menu icon element
    abstract splitButtonMenuIcon: IStyle option with get, set
    /// Style override for the SplitButton menu icon element in a disabled state
    abstract splitButtonMenuIconDisabled: IStyle option with get, set
    /// Style override for the SplitButton FlexContainer.
    abstract splitButtonFlexContainer: IStyle option with get, set

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] Button =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] ButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IButtonProps -> Button

type [<AllowNullLiteral>] ActionButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] ActionButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ActionButton

type [<AllowNullLiteral>] CommandBarButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CommandBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CommandBarButton

type [<AllowNullLiteral>] CompoundButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CompoundButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CompoundButton

type [<AllowNullLiteral>] DefaultButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DefaultButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DefaultButton

type [<AllowNullLiteral>] MessageBarButton =
    inherit BaseComponent<IButtonProps, obj>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] MessageBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> MessageBarButton

type [<AllowNullLiteral>] PrimaryButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] PrimaryButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> PrimaryButton

type [<AllowNullLiteral>] IconButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] IconButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> IconButton
type BaseComponent = ______Utilities.BaseComponent
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IButtonProps = __Button_types.IButtonProps
type IButton = __Button_types.IButton
type BaseButton = __BaseButton.BaseButton
type Button = __Button.Button
type IButtonClassNames = __BaseButton_classNames.IButtonClassNames
type ISplitButtonClassNames = __SplitButton_SplitButton_classNames.ISplitButtonClassNames
type IRenderFunction = ______Utilities.IRenderFunction
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IIconProps = ______Icon.IIconProps
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type BaseComponent = ______Utilities.BaseComponent
type IButtonProps = __Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract BaseButton: BaseButtonStatic
    abstract Button: ButtonStatic
    abstract ActionButton: ActionButtonStatic
    abstract CommandBarButton: CommandBarButtonStatic
    abstract CompoundButton: CompoundButtonStatic
    abstract DefaultButton: DefaultButtonStatic
    abstract MessageBarButton: MessageBarButtonStatic
    abstract PrimaryButton: PrimaryButtonStatic
    abstract IconButton: IconButtonStatic

type [<AllowNullLiteral>] IBaseButtonProps =
    inherit IButtonProps
    abstract baseClassName: string option with get, set
    abstract variantClassName: string option with get, set

type [<AllowNullLiteral>] IBaseButtonState =
    abstract menuProps: IContextualMenuProps option option with get, set

type [<AllowNullLiteral>] BaseButton =
    inherit BaseComponent<IBaseButtonProps, IBaseButtonState>
    inherit IButton
    abstract _isSplitButton: obj
    abstract _isExpanded: obj
    abstract defaultProps: obj with get, set
    abstract _buttonElement: obj with get, set
    abstract _splitButtonContainer: obj with get, set
    abstract _labelId: obj with get, set
    abstract _descriptionId: obj with get, set
    abstract _ariaDescriptionId: obj with get, set
    abstract _classNames: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidUpdate: prevProps: IBaseButtonProps * prevState: IBaseButtonState -> unit
    abstract focus: unit -> unit
    abstract dismissMenu: unit -> unit
    abstract _onRenderContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderIcon: ?buttonProps: obj * ?defaultRender: obj -> unit
    abstract _onRenderTextContents: unit -> unit
    abstract _onRenderText: unit -> unit
    abstract _onRenderChildren: unit -> unit
    abstract _onRenderDescription: props: obj -> unit
    abstract _onRenderAriaDescription: unit -> unit
    abstract _onRenderMenuIcon: props: obj -> unit
    abstract _onRenderMenu: menuProps: obj -> unit
    abstract _dismissMenu: unit -> unit
    abstract _onToggleMenu: unit -> unit
    abstract _onRenderSplitButtonContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderSplitButtonDivider: classNames: obj -> unit
    abstract _onRenderSplitButtonMenuButton: classNames: obj -> unit
    abstract _onMouseDown: ev: obj -> unit
    abstract _onMenuKeyDown: ev: obj -> unit
    abstract _onMenuClick: ev: obj -> unit

type [<AllowNullLiteral>] BaseButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IBaseButtonProps * rootClassName: string -> BaseButton

type [<AllowNullLiteral>] IButton =
    /// Sets focus to the button.
    abstract focus: (unit -> unit) with get, set
    /// If there is a menu associated with this button and it is visible, this will dismiss the menu
    abstract dismissMenu: (unit -> unit) with get, set

type [<AllowNullLiteral>] IButtonProps =
    inherit React.AllHTMLAttributes<U4<HTMLAnchorElement, HTMLButtonElement, BaseButton, Button>>
    /// Optional callback to access the IButton interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IButton -> unit) option with get, set
    /// If provided, this component will be rendered as an anchor.
    abstract href: string option with get, set
    /// Changes the visual presentation of the button to be emphasized (if defined)
    abstract primary: bool option with get, set
    /// Unique id to identify the item. Typically a duplicate of key value.
    abstract uniqueId: U2<string, float> option with get, set
    /// Whether the button is disabled
    abstract disabled: bool option with get, set
    /// If set to true and if this is a splitButton (split == true) then the primary action of a split button is disabled.
    abstract primaryDisabled: bool option with get, set
    /// Custom styling for individual elements within the button DOM.
    abstract styles: IButtonStyles option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Whether the button is checked
    abstract ``checked``: bool option with get, set
    /// If provided, additional class name to provide on the root element.
    abstract className: string option with get, set
    /// The aria label of the button for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// Detailed description of the button for the benefit of screen readers.
    /// 
    /// Besides the compound button, other button types will need more information provided to screen reader.
    abstract ariaDescription: string option with get, set
    /// If provided and is true it adds an 'aria-hidden' attribute instructing screen readers to ignore the element.
    abstract ariaHidden: bool option with get, set
    /// Text to render button label. If text is supplied, it will override any string in button children. Other children components will be passed through after the text.
    abstract text: string option with get, set
    /// The props for the icon shown in the button.
    abstract iconProps: IIconProps option with get, set
    /// Props for button menu. Providing this will default to showing the menu icon. See menuIconProps for overriding
    /// how the default icon looks. Providing this in addition of onClick and setting the split property to true will render a SplitButton.
    abstract menuProps: IContextualMenuProps option with get, set
    /// Callback that runs after Button's contextualmenu was closed (removed from the DOM)
    abstract onAfterMenuDismiss: (unit -> unit) option with get, set
    /// If set to true, and if menuProps and onClick are provided, the button will render as a SplitButton. Defaults to false.
    abstract split: bool option with get, set
    /// The props for the icon shown when providing a menu dropdown.
    abstract menuIconProps: IIconProps option with get, set
    /// Accessible label for the dropdown chevron button if this button is split.
    abstract splitButtonAriaLabel: string option with get, set
    /// Optional callback when menu is clicked.
    abstract onMenuClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IButtonProps -> unit) option with get, set
    /// Custom render function for the icon
    abstract onRenderIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the label text.
    abstract onRenderText: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the desciption text.
    abstract onRenderDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the aria description element.
    abstract onRenderAriaDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for rendering the button children.
    abstract onRenderChildren: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu icon
    abstract onRenderMenuIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu
    abstract onRenderMenu: IRenderFunction<IContextualMenuProps> option with get, set
    /// Description of the action this button takes.
    /// Only used for compound buttons
    abstract description: string option with get, set
    /// Deprecated at v1.2.3, to be removed at >= v2.0.0. Use specific button component instead
    abstract buttonType: ButtonType option with get, set
    /// Deprecated at v0.56.2, to be removed at >= v1.0.0. Just pass in button props instead;
    /// they will be mixed into the button/anchor element rendered by the component.
    abstract rootProps: U2<React.ButtonHTMLAttributes<HTMLButtonElement>, React.AnchorHTMLAttributes<HTMLAnchorElement>> option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract toggled: bool option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract data: obj option option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getClassNames: (ITheme -> string -> string -> string option -> string option -> bool -> bool -> bool -> bool option -> IButtonClassNames) option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getSplitButtonClassNames: (bool -> bool -> bool -> ISplitButtonClassNames) option with get, set

type [<RequireQualifiedAccess>] ElementType =
    | Button = 0
    | Anchor = 1

type [<RequireQualifiedAccess>] ButtonType =
    | Normal = 0
    | Primary = 1
    | Hero = 2
    | Compound = 3
    | Command = 4
    | Icon = 5
    | Default = 6

type [<AllowNullLiteral>] IButtonStyles =
    /// Style for the root element in the default enabled, non-toggled state.
    abstract root: IStyle option with get, set
    /// Style override for the root element in a checked state, layered on top of the root style.
    abstract rootChecked: IStyle option with get, set
    /// Style override for the root element in a disabled state, layered on top of the root style.
    abstract rootDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootHovered: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootFocused: IStyle option with get, set
    /// Style override applied to the root on pressed in the default, enabled, non-toggled state.
    abstract rootPressed: IStyle option with get, set
    /// Style override applied to the root on when menu is expanded in the default, enabled, non-toggled state.
    abstract rootExpanded: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, enabled state
    abstract rootCheckedHovered: IStyle option with get, set
    /// Style override applied to the root on pressed in a checked, enabled state
    abstract rootCheckedPressed: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, disabled state
    abstract rootCheckedDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in a expanded state on hover
    abstract rootExpandedHovered: IStyle option with get, set
    /// Style for the flexbox container within the root element.
    abstract flexContainer: IStyle option with get, set
    /// Style for the text container within the flexbox container element (and contains the text and description).
    abstract textContainer: IStyle option with get, set
    /// Style for the icon on the near side of the label.
    abstract icon: IStyle option with get, set
    /// Style for the icon on the near side of the label on hover.
    abstract iconHovered: IStyle option with get, set
    /// Style for the icon on the near side of the label when pressed.
    abstract iconPressed: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded.
    abstract iconExpanded: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded and hovered.
    abstract iconExpandedHovered: IStyle option with get, set
    /// Style override for the icon when the button is disabled.
    abstract iconDisabled: IStyle option with get, set
    /// Style override for the icon when the button is checked.
    abstract iconChecked: IStyle option with get, set
    /// Style for the text content of the button.
    abstract label: IStyle option with get, set
    /// Style override for the text content when the button is disabled.
    abstract labelDisabled: IStyle option with get, set
    /// Style override for the text content when the button is checked.
    abstract labelChecked: IStyle option with get, set
    /// Style for the menu chevron.
    abstract menuIcon: IStyle option with get, set
    /// Style for the menu chevron on hover.
    abstract menuIconHovered: IStyle option with get, set
    /// Style for the menu chevron when pressed.
    abstract menuIconPressed: IStyle option with get, set
    /// Style for the menu chevron when expanded.
    abstract menuIconExpanded: IStyle option with get, set
    /// Style for the menu chevron when expanded and hovered.
    abstract menuIconExpandedHovered: IStyle option with get, set
    /// Style override for the menu chevron when the button is disabled.
    abstract menuIconDisabled: IStyle option with get, set
    /// Style override for the menu chevron when the button is checked.
    abstract menuIconChecked: IStyle option with get, set
    /// Style for the description text if applicable (for compound buttons.)
    abstract description: IStyle option with get, set
    /// Style override for the description text when the button is hovered.
    abstract descriptionHovered: IStyle option with get, set
    /// Style for the description text when the button is pressed.
    abstract descriptionPressed: IStyle option with get, set
    /// Style override for the description text when the button is disabled.
    abstract descriptionDisabled: IStyle option with get, set
    /// Style override for the description text when the button is checked.
    abstract descriptionChecked: IStyle option with get, set
    /// Style override for the screen reader text.
    abstract screenReaderText: IStyle option with get, set
    /// Style override for the container div around a SplitButton element
    abstract splitButtonContainer: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is hovered.
    abstract splitButtonContainerHovered: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is focused.
    abstract splitButtonContainerFocused: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked.
    abstract splitButtonContainerChecked: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked and hovered.
    abstract splitButtonContainerCheckedHovered: IStyle option with get, set
    /// Style override for the container div around a SplitButton element in a disabled state
    abstract splitButtonContainerDisabled: IStyle option with get, set
    /// Style override for the divider element that appears between the button and menu button
    /// for a split button.
    abstract splitButtonDivider: IStyle option with get, set
    /// Style override for the SplitButton menu button
    abstract splitButtonMenuButton: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a disabled state.
    abstract splitButtonMenuButtonDisabled: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a checked state
    abstract splitButtonMenuButtonChecked: IStyle option with get, set
    /// Style override for the SplitButton menu button element in an expanded state
    abstract splitButtonMenuButtonExpanded: IStyle option with get, set
    /// Style override for the SplitButton menu icon element
    abstract splitButtonMenuIcon: IStyle option with get, set
    /// Style override for the SplitButton menu icon element in a disabled state
    abstract splitButtonMenuIconDisabled: IStyle option with get, set
    /// Style override for the SplitButton FlexContainer.
    abstract splitButtonFlexContainer: IStyle option with get, set

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] Button =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] ButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IButtonProps -> Button

type [<AllowNullLiteral>] ActionButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] ActionButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ActionButton

type [<AllowNullLiteral>] CommandBarButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CommandBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CommandBarButton

type [<AllowNullLiteral>] CompoundButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CompoundButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CompoundButton

type [<AllowNullLiteral>] DefaultButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DefaultButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DefaultButton

type [<AllowNullLiteral>] MessageBarButton =
    inherit BaseComponent<IButtonProps, obj>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] MessageBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> MessageBarButton

type [<AllowNullLiteral>] PrimaryButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] PrimaryButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> PrimaryButton

type [<AllowNullLiteral>] IconButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] IconButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> IconButton
type BaseComponent = ______Utilities.BaseComponent
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IButtonProps = __Button_types.IButtonProps
type IButton = __Button_types.IButton
type BaseButton = __BaseButton.BaseButton
type Button = __Button.Button
type IButtonClassNames = __BaseButton_classNames.IButtonClassNames
type ISplitButtonClassNames = __SplitButton_SplitButton_classNames.ISplitButtonClassNames
type IRenderFunction = ______Utilities.IRenderFunction
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IIconProps = ______Icon.IIconProps
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type BaseComponent = ______Utilities.BaseComponent
type IButtonProps = __Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract BaseButton: BaseButtonStatic
    abstract Button: ButtonStatic
    abstract ActionButton: ActionButtonStatic
    abstract CommandBarButton: CommandBarButtonStatic
    abstract CompoundButton: CompoundButtonStatic
    abstract DefaultButton: DefaultButtonStatic
    abstract MessageBarButton: MessageBarButtonStatic
    abstract PrimaryButton: PrimaryButtonStatic
    abstract IconButton: IconButtonStatic

type [<AllowNullLiteral>] IBaseButtonProps =
    inherit IButtonProps
    abstract baseClassName: string option with get, set
    abstract variantClassName: string option with get, set

type [<AllowNullLiteral>] IBaseButtonState =
    abstract menuProps: IContextualMenuProps option option with get, set

type [<AllowNullLiteral>] BaseButton =
    inherit BaseComponent<IBaseButtonProps, IBaseButtonState>
    inherit IButton
    abstract _isSplitButton: obj
    abstract _isExpanded: obj
    abstract defaultProps: obj with get, set
    abstract _buttonElement: obj with get, set
    abstract _splitButtonContainer: obj with get, set
    abstract _labelId: obj with get, set
    abstract _descriptionId: obj with get, set
    abstract _ariaDescriptionId: obj with get, set
    abstract _classNames: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidUpdate: prevProps: IBaseButtonProps * prevState: IBaseButtonState -> unit
    abstract focus: unit -> unit
    abstract dismissMenu: unit -> unit
    abstract _onRenderContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderIcon: ?buttonProps: obj * ?defaultRender: obj -> unit
    abstract _onRenderTextContents: unit -> unit
    abstract _onRenderText: unit -> unit
    abstract _onRenderChildren: unit -> unit
    abstract _onRenderDescription: props: obj -> unit
    abstract _onRenderAriaDescription: unit -> unit
    abstract _onRenderMenuIcon: props: obj -> unit
    abstract _onRenderMenu: menuProps: obj -> unit
    abstract _dismissMenu: unit -> unit
    abstract _onToggleMenu: unit -> unit
    abstract _onRenderSplitButtonContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderSplitButtonDivider: classNames: obj -> unit
    abstract _onRenderSplitButtonMenuButton: classNames: obj -> unit
    abstract _onMouseDown: ev: obj -> unit
    abstract _onMenuKeyDown: ev: obj -> unit
    abstract _onMenuClick: ev: obj -> unit

type [<AllowNullLiteral>] BaseButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IBaseButtonProps * rootClassName: string -> BaseButton

type [<AllowNullLiteral>] IButton =
    /// Sets focus to the button.
    abstract focus: (unit -> unit) with get, set
    /// If there is a menu associated with this button and it is visible, this will dismiss the menu
    abstract dismissMenu: (unit -> unit) with get, set

type [<AllowNullLiteral>] IButtonProps =
    inherit React.AllHTMLAttributes<U4<HTMLAnchorElement, HTMLButtonElement, BaseButton, Button>>
    /// Optional callback to access the IButton interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IButton -> unit) option with get, set
    /// If provided, this component will be rendered as an anchor.
    abstract href: string option with get, set
    /// Changes the visual presentation of the button to be emphasized (if defined)
    abstract primary: bool option with get, set
    /// Unique id to identify the item. Typically a duplicate of key value.
    abstract uniqueId: U2<string, float> option with get, set
    /// Whether the button is disabled
    abstract disabled: bool option with get, set
    /// If set to true and if this is a splitButton (split == true) then the primary action of a split button is disabled.
    abstract primaryDisabled: bool option with get, set
    /// Custom styling for individual elements within the button DOM.
    abstract styles: IButtonStyles option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Whether the button is checked
    abstract ``checked``: bool option with get, set
    /// If provided, additional class name to provide on the root element.
    abstract className: string option with get, set
    /// The aria label of the button for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// Detailed description of the button for the benefit of screen readers.
    /// 
    /// Besides the compound button, other button types will need more information provided to screen reader.
    abstract ariaDescription: string option with get, set
    /// If provided and is true it adds an 'aria-hidden' attribute instructing screen readers to ignore the element.
    abstract ariaHidden: bool option with get, set
    /// Text to render button label. If text is supplied, it will override any string in button children. Other children components will be passed through after the text.
    abstract text: string option with get, set
    /// The props for the icon shown in the button.
    abstract iconProps: IIconProps option with get, set
    /// Props for button menu. Providing this will default to showing the menu icon. See menuIconProps for overriding
    /// how the default icon looks. Providing this in addition of onClick and setting the split property to true will render a SplitButton.
    abstract menuProps: IContextualMenuProps option with get, set
    /// Callback that runs after Button's contextualmenu was closed (removed from the DOM)
    abstract onAfterMenuDismiss: (unit -> unit) option with get, set
    /// If set to true, and if menuProps and onClick are provided, the button will render as a SplitButton. Defaults to false.
    abstract split: bool option with get, set
    /// The props for the icon shown when providing a menu dropdown.
    abstract menuIconProps: IIconProps option with get, set
    /// Accessible label for the dropdown chevron button if this button is split.
    abstract splitButtonAriaLabel: string option with get, set
    /// Optional callback when menu is clicked.
    abstract onMenuClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IButtonProps -> unit) option with get, set
    /// Custom render function for the icon
    abstract onRenderIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the label text.
    abstract onRenderText: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the desciption text.
    abstract onRenderDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the aria description element.
    abstract onRenderAriaDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for rendering the button children.
    abstract onRenderChildren: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu icon
    abstract onRenderMenuIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu
    abstract onRenderMenu: IRenderFunction<IContextualMenuProps> option with get, set
    /// Description of the action this button takes.
    /// Only used for compound buttons
    abstract description: string option with get, set
    /// Deprecated at v1.2.3, to be removed at >= v2.0.0. Use specific button component instead
    abstract buttonType: ButtonType option with get, set
    /// Deprecated at v0.56.2, to be removed at >= v1.0.0. Just pass in button props instead;
    /// they will be mixed into the button/anchor element rendered by the component.
    abstract rootProps: U2<React.ButtonHTMLAttributes<HTMLButtonElement>, React.AnchorHTMLAttributes<HTMLAnchorElement>> option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract toggled: bool option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract data: obj option option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getClassNames: (ITheme -> string -> string -> string option -> string option -> bool -> bool -> bool -> bool option -> IButtonClassNames) option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getSplitButtonClassNames: (bool -> bool -> bool -> ISplitButtonClassNames) option with get, set

type [<RequireQualifiedAccess>] ElementType =
    | Button = 0
    | Anchor = 1

type [<RequireQualifiedAccess>] ButtonType =
    | Normal = 0
    | Primary = 1
    | Hero = 2
    | Compound = 3
    | Command = 4
    | Icon = 5
    | Default = 6

type [<AllowNullLiteral>] IButtonStyles =
    /// Style for the root element in the default enabled, non-toggled state.
    abstract root: IStyle option with get, set
    /// Style override for the root element in a checked state, layered on top of the root style.
    abstract rootChecked: IStyle option with get, set
    /// Style override for the root element in a disabled state, layered on top of the root style.
    abstract rootDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootHovered: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootFocused: IStyle option with get, set
    /// Style override applied to the root on pressed in the default, enabled, non-toggled state.
    abstract rootPressed: IStyle option with get, set
    /// Style override applied to the root on when menu is expanded in the default, enabled, non-toggled state.
    abstract rootExpanded: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, enabled state
    abstract rootCheckedHovered: IStyle option with get, set
    /// Style override applied to the root on pressed in a checked, enabled state
    abstract rootCheckedPressed: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, disabled state
    abstract rootCheckedDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in a expanded state on hover
    abstract rootExpandedHovered: IStyle option with get, set
    /// Style for the flexbox container within the root element.
    abstract flexContainer: IStyle option with get, set
    /// Style for the text container within the flexbox container element (and contains the text and description).
    abstract textContainer: IStyle option with get, set
    /// Style for the icon on the near side of the label.
    abstract icon: IStyle option with get, set
    /// Style for the icon on the near side of the label on hover.
    abstract iconHovered: IStyle option with get, set
    /// Style for the icon on the near side of the label when pressed.
    abstract iconPressed: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded.
    abstract iconExpanded: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded and hovered.
    abstract iconExpandedHovered: IStyle option with get, set
    /// Style override for the icon when the button is disabled.
    abstract iconDisabled: IStyle option with get, set
    /// Style override for the icon when the button is checked.
    abstract iconChecked: IStyle option with get, set
    /// Style for the text content of the button.
    abstract label: IStyle option with get, set
    /// Style override for the text content when the button is disabled.
    abstract labelDisabled: IStyle option with get, set
    /// Style override for the text content when the button is checked.
    abstract labelChecked: IStyle option with get, set
    /// Style for the menu chevron.
    abstract menuIcon: IStyle option with get, set
    /// Style for the menu chevron on hover.
    abstract menuIconHovered: IStyle option with get, set
    /// Style for the menu chevron when pressed.
    abstract menuIconPressed: IStyle option with get, set
    /// Style for the menu chevron when expanded.
    abstract menuIconExpanded: IStyle option with get, set
    /// Style for the menu chevron when expanded and hovered.
    abstract menuIconExpandedHovered: IStyle option with get, set
    /// Style override for the menu chevron when the button is disabled.
    abstract menuIconDisabled: IStyle option with get, set
    /// Style override for the menu chevron when the button is checked.
    abstract menuIconChecked: IStyle option with get, set
    /// Style for the description text if applicable (for compound buttons.)
    abstract description: IStyle option with get, set
    /// Style override for the description text when the button is hovered.
    abstract descriptionHovered: IStyle option with get, set
    /// Style for the description text when the button is pressed.
    abstract descriptionPressed: IStyle option with get, set
    /// Style override for the description text when the button is disabled.
    abstract descriptionDisabled: IStyle option with get, set
    /// Style override for the description text when the button is checked.
    abstract descriptionChecked: IStyle option with get, set
    /// Style override for the screen reader text.
    abstract screenReaderText: IStyle option with get, set
    /// Style override for the container div around a SplitButton element
    abstract splitButtonContainer: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is hovered.
    abstract splitButtonContainerHovered: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is focused.
    abstract splitButtonContainerFocused: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked.
    abstract splitButtonContainerChecked: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked and hovered.
    abstract splitButtonContainerCheckedHovered: IStyle option with get, set
    /// Style override for the container div around a SplitButton element in a disabled state
    abstract splitButtonContainerDisabled: IStyle option with get, set
    /// Style override for the divider element that appears between the button and menu button
    /// for a split button.
    abstract splitButtonDivider: IStyle option with get, set
    /// Style override for the SplitButton menu button
    abstract splitButtonMenuButton: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a disabled state.
    abstract splitButtonMenuButtonDisabled: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a checked state
    abstract splitButtonMenuButtonChecked: IStyle option with get, set
    /// Style override for the SplitButton menu button element in an expanded state
    abstract splitButtonMenuButtonExpanded: IStyle option with get, set
    /// Style override for the SplitButton menu icon element
    abstract splitButtonMenuIcon: IStyle option with get, set
    /// Style override for the SplitButton menu icon element in a disabled state
    abstract splitButtonMenuIconDisabled: IStyle option with get, set
    /// Style override for the SplitButton FlexContainer.
    abstract splitButtonFlexContainer: IStyle option with get, set

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] Button =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] ButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IButtonProps -> Button

type [<AllowNullLiteral>] ActionButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] ActionButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ActionButton

type [<AllowNullLiteral>] CommandBarButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CommandBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CommandBarButton

type [<AllowNullLiteral>] CompoundButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CompoundButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CompoundButton

type [<AllowNullLiteral>] DefaultButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DefaultButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DefaultButton

type [<AllowNullLiteral>] MessageBarButton =
    inherit BaseComponent<IButtonProps, obj>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] MessageBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> MessageBarButton

type [<AllowNullLiteral>] PrimaryButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] PrimaryButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> PrimaryButton

type [<AllowNullLiteral>] IconButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] IconButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> IconButton
type BaseComponent = ______Utilities.BaseComponent
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IButtonProps = __Button_types.IButtonProps
type IButton = __Button_types.IButton
type BaseButton = __BaseButton.BaseButton
type Button = __Button.Button
type IButtonClassNames = __BaseButton_classNames.IButtonClassNames
type ISplitButtonClassNames = __SplitButton_SplitButton_classNames.ISplitButtonClassNames
type IRenderFunction = ______Utilities.IRenderFunction
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IIconProps = ______Icon.IIconProps
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type BaseComponent = ______Utilities.BaseComponent
type IButtonProps = __Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract BaseButton: BaseButtonStatic
    abstract Button: ButtonStatic
    abstract ActionButton: ActionButtonStatic
    abstract CommandBarButton: CommandBarButtonStatic
    abstract CompoundButton: CompoundButtonStatic
    abstract DefaultButton: DefaultButtonStatic
    abstract MessageBarButton: MessageBarButtonStatic
    abstract PrimaryButton: PrimaryButtonStatic
    abstract IconButton: IconButtonStatic

type [<AllowNullLiteral>] IBaseButtonProps =
    inherit IButtonProps
    abstract baseClassName: string option with get, set
    abstract variantClassName: string option with get, set

type [<AllowNullLiteral>] IBaseButtonState =
    abstract menuProps: IContextualMenuProps option option with get, set

type [<AllowNullLiteral>] BaseButton =
    inherit BaseComponent<IBaseButtonProps, IBaseButtonState>
    inherit IButton
    abstract _isSplitButton: obj
    abstract _isExpanded: obj
    abstract defaultProps: obj with get, set
    abstract _buttonElement: obj with get, set
    abstract _splitButtonContainer: obj with get, set
    abstract _labelId: obj with get, set
    abstract _descriptionId: obj with get, set
    abstract _ariaDescriptionId: obj with get, set
    abstract _classNames: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidUpdate: prevProps: IBaseButtonProps * prevState: IBaseButtonState -> unit
    abstract focus: unit -> unit
    abstract dismissMenu: unit -> unit
    abstract _onRenderContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderIcon: ?buttonProps: obj * ?defaultRender: obj -> unit
    abstract _onRenderTextContents: unit -> unit
    abstract _onRenderText: unit -> unit
    abstract _onRenderChildren: unit -> unit
    abstract _onRenderDescription: props: obj -> unit
    abstract _onRenderAriaDescription: unit -> unit
    abstract _onRenderMenuIcon: props: obj -> unit
    abstract _onRenderMenu: menuProps: obj -> unit
    abstract _dismissMenu: unit -> unit
    abstract _onToggleMenu: unit -> unit
    abstract _onRenderSplitButtonContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderSplitButtonDivider: classNames: obj -> unit
    abstract _onRenderSplitButtonMenuButton: classNames: obj -> unit
    abstract _onMouseDown: ev: obj -> unit
    abstract _onMenuKeyDown: ev: obj -> unit
    abstract _onMenuClick: ev: obj -> unit

type [<AllowNullLiteral>] BaseButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IBaseButtonProps * rootClassName: string -> BaseButton

type [<AllowNullLiteral>] IButton =
    /// Sets focus to the button.
    abstract focus: (unit -> unit) with get, set
    /// If there is a menu associated with this button and it is visible, this will dismiss the menu
    abstract dismissMenu: (unit -> unit) with get, set

type [<AllowNullLiteral>] IButtonProps =
    inherit React.AllHTMLAttributes<U4<HTMLAnchorElement, HTMLButtonElement, BaseButton, Button>>
    /// Optional callback to access the IButton interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IButton -> unit) option with get, set
    /// If provided, this component will be rendered as an anchor.
    abstract href: string option with get, set
    /// Changes the visual presentation of the button to be emphasized (if defined)
    abstract primary: bool option with get, set
    /// Unique id to identify the item. Typically a duplicate of key value.
    abstract uniqueId: U2<string, float> option with get, set
    /// Whether the button is disabled
    abstract disabled: bool option with get, set
    /// If set to true and if this is a splitButton (split == true) then the primary action of a split button is disabled.
    abstract primaryDisabled: bool option with get, set
    /// Custom styling for individual elements within the button DOM.
    abstract styles: IButtonStyles option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Whether the button is checked
    abstract ``checked``: bool option with get, set
    /// If provided, additional class name to provide on the root element.
    abstract className: string option with get, set
    /// The aria label of the button for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// Detailed description of the button for the benefit of screen readers.
    /// 
    /// Besides the compound button, other button types will need more information provided to screen reader.
    abstract ariaDescription: string option with get, set
    /// If provided and is true it adds an 'aria-hidden' attribute instructing screen readers to ignore the element.
    abstract ariaHidden: bool option with get, set
    /// Text to render button label. If text is supplied, it will override any string in button children. Other children components will be passed through after the text.
    abstract text: string option with get, set
    /// The props for the icon shown in the button.
    abstract iconProps: IIconProps option with get, set
    /// Props for button menu. Providing this will default to showing the menu icon. See menuIconProps for overriding
    /// how the default icon looks. Providing this in addition of onClick and setting the split property to true will render a SplitButton.
    abstract menuProps: IContextualMenuProps option with get, set
    /// Callback that runs after Button's contextualmenu was closed (removed from the DOM)
    abstract onAfterMenuDismiss: (unit -> unit) option with get, set
    /// If set to true, and if menuProps and onClick are provided, the button will render as a SplitButton. Defaults to false.
    abstract split: bool option with get, set
    /// The props for the icon shown when providing a menu dropdown.
    abstract menuIconProps: IIconProps option with get, set
    /// Accessible label for the dropdown chevron button if this button is split.
    abstract splitButtonAriaLabel: string option with get, set
    /// Optional callback when menu is clicked.
    abstract onMenuClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IButtonProps -> unit) option with get, set
    /// Custom render function for the icon
    abstract onRenderIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the label text.
    abstract onRenderText: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the desciption text.
    abstract onRenderDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the aria description element.
    abstract onRenderAriaDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for rendering the button children.
    abstract onRenderChildren: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu icon
    abstract onRenderMenuIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu
    abstract onRenderMenu: IRenderFunction<IContextualMenuProps> option with get, set
    /// Description of the action this button takes.
    /// Only used for compound buttons
    abstract description: string option with get, set
    /// Deprecated at v1.2.3, to be removed at >= v2.0.0. Use specific button component instead
    abstract buttonType: ButtonType option with get, set
    /// Deprecated at v0.56.2, to be removed at >= v1.0.0. Just pass in button props instead;
    /// they will be mixed into the button/anchor element rendered by the component.
    abstract rootProps: U2<React.ButtonHTMLAttributes<HTMLButtonElement>, React.AnchorHTMLAttributes<HTMLAnchorElement>> option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract toggled: bool option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract data: obj option option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getClassNames: (ITheme -> string -> string -> string option -> string option -> bool -> bool -> bool -> bool option -> IButtonClassNames) option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getSplitButtonClassNames: (bool -> bool -> bool -> ISplitButtonClassNames) option with get, set

type [<RequireQualifiedAccess>] ElementType =
    | Button = 0
    | Anchor = 1

type [<RequireQualifiedAccess>] ButtonType =
    | Normal = 0
    | Primary = 1
    | Hero = 2
    | Compound = 3
    | Command = 4
    | Icon = 5
    | Default = 6

type [<AllowNullLiteral>] IButtonStyles =
    /// Style for the root element in the default enabled, non-toggled state.
    abstract root: IStyle option with get, set
    /// Style override for the root element in a checked state, layered on top of the root style.
    abstract rootChecked: IStyle option with get, set
    /// Style override for the root element in a disabled state, layered on top of the root style.
    abstract rootDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootHovered: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootFocused: IStyle option with get, set
    /// Style override applied to the root on pressed in the default, enabled, non-toggled state.
    abstract rootPressed: IStyle option with get, set
    /// Style override applied to the root on when menu is expanded in the default, enabled, non-toggled state.
    abstract rootExpanded: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, enabled state
    abstract rootCheckedHovered: IStyle option with get, set
    /// Style override applied to the root on pressed in a checked, enabled state
    abstract rootCheckedPressed: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, disabled state
    abstract rootCheckedDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in a expanded state on hover
    abstract rootExpandedHovered: IStyle option with get, set
    /// Style for the flexbox container within the root element.
    abstract flexContainer: IStyle option with get, set
    /// Style for the text container within the flexbox container element (and contains the text and description).
    abstract textContainer: IStyle option with get, set
    /// Style for the icon on the near side of the label.
    abstract icon: IStyle option with get, set
    /// Style for the icon on the near side of the label on hover.
    abstract iconHovered: IStyle option with get, set
    /// Style for the icon on the near side of the label when pressed.
    abstract iconPressed: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded.
    abstract iconExpanded: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded and hovered.
    abstract iconExpandedHovered: IStyle option with get, set
    /// Style override for the icon when the button is disabled.
    abstract iconDisabled: IStyle option with get, set
    /// Style override for the icon when the button is checked.
    abstract iconChecked: IStyle option with get, set
    /// Style for the text content of the button.
    abstract label: IStyle option with get, set
    /// Style override for the text content when the button is disabled.
    abstract labelDisabled: IStyle option with get, set
    /// Style override for the text content when the button is checked.
    abstract labelChecked: IStyle option with get, set
    /// Style for the menu chevron.
    abstract menuIcon: IStyle option with get, set
    /// Style for the menu chevron on hover.
    abstract menuIconHovered: IStyle option with get, set
    /// Style for the menu chevron when pressed.
    abstract menuIconPressed: IStyle option with get, set
    /// Style for the menu chevron when expanded.
    abstract menuIconExpanded: IStyle option with get, set
    /// Style for the menu chevron when expanded and hovered.
    abstract menuIconExpandedHovered: IStyle option with get, set
    /// Style override for the menu chevron when the button is disabled.
    abstract menuIconDisabled: IStyle option with get, set
    /// Style override for the menu chevron when the button is checked.
    abstract menuIconChecked: IStyle option with get, set
    /// Style for the description text if applicable (for compound buttons.)
    abstract description: IStyle option with get, set
    /// Style override for the description text when the button is hovered.
    abstract descriptionHovered: IStyle option with get, set
    /// Style for the description text when the button is pressed.
    abstract descriptionPressed: IStyle option with get, set
    /// Style override for the description text when the button is disabled.
    abstract descriptionDisabled: IStyle option with get, set
    /// Style override for the description text when the button is checked.
    abstract descriptionChecked: IStyle option with get, set
    /// Style override for the screen reader text.
    abstract screenReaderText: IStyle option with get, set
    /// Style override for the container div around a SplitButton element
    abstract splitButtonContainer: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is hovered.
    abstract splitButtonContainerHovered: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is focused.
    abstract splitButtonContainerFocused: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked.
    abstract splitButtonContainerChecked: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked and hovered.
    abstract splitButtonContainerCheckedHovered: IStyle option with get, set
    /// Style override for the container div around a SplitButton element in a disabled state
    abstract splitButtonContainerDisabled: IStyle option with get, set
    /// Style override for the divider element that appears between the button and menu button
    /// for a split button.
    abstract splitButtonDivider: IStyle option with get, set
    /// Style override for the SplitButton menu button
    abstract splitButtonMenuButton: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a disabled state.
    abstract splitButtonMenuButtonDisabled: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a checked state
    abstract splitButtonMenuButtonChecked: IStyle option with get, set
    /// Style override for the SplitButton menu button element in an expanded state
    abstract splitButtonMenuButtonExpanded: IStyle option with get, set
    /// Style override for the SplitButton menu icon element
    abstract splitButtonMenuIcon: IStyle option with get, set
    /// Style override for the SplitButton menu icon element in a disabled state
    abstract splitButtonMenuIconDisabled: IStyle option with get, set
    /// Style override for the SplitButton FlexContainer.
    abstract splitButtonFlexContainer: IStyle option with get, set

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] Button =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] ButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IButtonProps -> Button

type [<AllowNullLiteral>] ActionButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] ActionButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ActionButton

type [<AllowNullLiteral>] CommandBarButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CommandBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CommandBarButton

type [<AllowNullLiteral>] CompoundButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CompoundButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CompoundButton

type [<AllowNullLiteral>] DefaultButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DefaultButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DefaultButton

type [<AllowNullLiteral>] MessageBarButton =
    inherit BaseComponent<IButtonProps, obj>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] MessageBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> MessageBarButton

type [<AllowNullLiteral>] PrimaryButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] PrimaryButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> PrimaryButton

type [<AllowNullLiteral>] IconButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] IconButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> IconButton
type BaseComponent = ______Utilities.BaseComponent
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IButtonProps = __Button_types.IButtonProps
type IButton = __Button_types.IButton
type BaseButton = __BaseButton.BaseButton
type Button = __Button.Button
type IButtonClassNames = __BaseButton_classNames.IButtonClassNames
type ISplitButtonClassNames = __SplitButton_SplitButton_classNames.ISplitButtonClassNames
type IRenderFunction = ______Utilities.IRenderFunction
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IIconProps = ______Icon.IIconProps
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type BaseComponent = ______Utilities.BaseComponent
type IButtonProps = __Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract BaseButton: BaseButtonStatic
    abstract Button: ButtonStatic
    abstract ActionButton: ActionButtonStatic
    abstract CommandBarButton: CommandBarButtonStatic
    abstract CompoundButton: CompoundButtonStatic
    abstract DefaultButton: DefaultButtonStatic
    abstract MessageBarButton: MessageBarButtonStatic
    abstract PrimaryButton: PrimaryButtonStatic
    abstract IconButton: IconButtonStatic

type [<AllowNullLiteral>] IBaseButtonProps =
    inherit IButtonProps
    abstract baseClassName: string option with get, set
    abstract variantClassName: string option with get, set

type [<AllowNullLiteral>] IBaseButtonState =
    abstract menuProps: IContextualMenuProps option option with get, set

type [<AllowNullLiteral>] BaseButton =
    inherit BaseComponent<IBaseButtonProps, IBaseButtonState>
    inherit IButton
    abstract _isSplitButton: obj
    abstract _isExpanded: obj
    abstract defaultProps: obj with get, set
    abstract _buttonElement: obj with get, set
    abstract _splitButtonContainer: obj with get, set
    abstract _labelId: obj with get, set
    abstract _descriptionId: obj with get, set
    abstract _ariaDescriptionId: obj with get, set
    abstract _classNames: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidUpdate: prevProps: IBaseButtonProps * prevState: IBaseButtonState -> unit
    abstract focus: unit -> unit
    abstract dismissMenu: unit -> unit
    abstract _onRenderContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderIcon: ?buttonProps: obj * ?defaultRender: obj -> unit
    abstract _onRenderTextContents: unit -> unit
    abstract _onRenderText: unit -> unit
    abstract _onRenderChildren: unit -> unit
    abstract _onRenderDescription: props: obj -> unit
    abstract _onRenderAriaDescription: unit -> unit
    abstract _onRenderMenuIcon: props: obj -> unit
    abstract _onRenderMenu: menuProps: obj -> unit
    abstract _dismissMenu: unit -> unit
    abstract _onToggleMenu: unit -> unit
    abstract _onRenderSplitButtonContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderSplitButtonDivider: classNames: obj -> unit
    abstract _onRenderSplitButtonMenuButton: classNames: obj -> unit
    abstract _onMouseDown: ev: obj -> unit
    abstract _onMenuKeyDown: ev: obj -> unit
    abstract _onMenuClick: ev: obj -> unit

type [<AllowNullLiteral>] BaseButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IBaseButtonProps * rootClassName: string -> BaseButton

type [<AllowNullLiteral>] IButton =
    /// Sets focus to the button.
    abstract focus: (unit -> unit) with get, set
    /// If there is a menu associated with this button and it is visible, this will dismiss the menu
    abstract dismissMenu: (unit -> unit) with get, set

type [<AllowNullLiteral>] IButtonProps =
    inherit React.AllHTMLAttributes<U4<HTMLAnchorElement, HTMLButtonElement, BaseButton, Button>>
    /// Optional callback to access the IButton interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IButton -> unit) option with get, set
    /// If provided, this component will be rendered as an anchor.
    abstract href: string option with get, set
    /// Changes the visual presentation of the button to be emphasized (if defined)
    abstract primary: bool option with get, set
    /// Unique id to identify the item. Typically a duplicate of key value.
    abstract uniqueId: U2<string, float> option with get, set
    /// Whether the button is disabled
    abstract disabled: bool option with get, set
    /// If set to true and if this is a splitButton (split == true) then the primary action of a split button is disabled.
    abstract primaryDisabled: bool option with get, set
    /// Custom styling for individual elements within the button DOM.
    abstract styles: IButtonStyles option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Whether the button is checked
    abstract ``checked``: bool option with get, set
    /// If provided, additional class name to provide on the root element.
    abstract className: string option with get, set
    /// The aria label of the button for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// Detailed description of the button for the benefit of screen readers.
    /// 
    /// Besides the compound button, other button types will need more information provided to screen reader.
    abstract ariaDescription: string option with get, set
    /// If provided and is true it adds an 'aria-hidden' attribute instructing screen readers to ignore the element.
    abstract ariaHidden: bool option with get, set
    /// Text to render button label. If text is supplied, it will override any string in button children. Other children components will be passed through after the text.
    abstract text: string option with get, set
    /// The props for the icon shown in the button.
    abstract iconProps: IIconProps option with get, set
    /// Props for button menu. Providing this will default to showing the menu icon. See menuIconProps for overriding
    /// how the default icon looks. Providing this in addition of onClick and setting the split property to true will render a SplitButton.
    abstract menuProps: IContextualMenuProps option with get, set
    /// Callback that runs after Button's contextualmenu was closed (removed from the DOM)
    abstract onAfterMenuDismiss: (unit -> unit) option with get, set
    /// If set to true, and if menuProps and onClick are provided, the button will render as a SplitButton. Defaults to false.
    abstract split: bool option with get, set
    /// The props for the icon shown when providing a menu dropdown.
    abstract menuIconProps: IIconProps option with get, set
    /// Accessible label for the dropdown chevron button if this button is split.
    abstract splitButtonAriaLabel: string option with get, set
    /// Optional callback when menu is clicked.
    abstract onMenuClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IButtonProps -> unit) option with get, set
    /// Custom render function for the icon
    abstract onRenderIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the label text.
    abstract onRenderText: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the desciption text.
    abstract onRenderDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the aria description element.
    abstract onRenderAriaDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for rendering the button children.
    abstract onRenderChildren: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu icon
    abstract onRenderMenuIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu
    abstract onRenderMenu: IRenderFunction<IContextualMenuProps> option with get, set
    /// Description of the action this button takes.
    /// Only used for compound buttons
    abstract description: string option with get, set
    /// Deprecated at v1.2.3, to be removed at >= v2.0.0. Use specific button component instead
    abstract buttonType: ButtonType option with get, set
    /// Deprecated at v0.56.2, to be removed at >= v1.0.0. Just pass in button props instead;
    /// they will be mixed into the button/anchor element rendered by the component.
    abstract rootProps: U2<React.ButtonHTMLAttributes<HTMLButtonElement>, React.AnchorHTMLAttributes<HTMLAnchorElement>> option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract toggled: bool option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract data: obj option option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getClassNames: (ITheme -> string -> string -> string option -> string option -> bool -> bool -> bool -> bool option -> IButtonClassNames) option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getSplitButtonClassNames: (bool -> bool -> bool -> ISplitButtonClassNames) option with get, set

type [<RequireQualifiedAccess>] ElementType =
    | Button = 0
    | Anchor = 1

type [<RequireQualifiedAccess>] ButtonType =
    | Normal = 0
    | Primary = 1
    | Hero = 2
    | Compound = 3
    | Command = 4
    | Icon = 5
    | Default = 6

type [<AllowNullLiteral>] IButtonStyles =
    /// Style for the root element in the default enabled, non-toggled state.
    abstract root: IStyle option with get, set
    /// Style override for the root element in a checked state, layered on top of the root style.
    abstract rootChecked: IStyle option with get, set
    /// Style override for the root element in a disabled state, layered on top of the root style.
    abstract rootDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootHovered: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootFocused: IStyle option with get, set
    /// Style override applied to the root on pressed in the default, enabled, non-toggled state.
    abstract rootPressed: IStyle option with get, set
    /// Style override applied to the root on when menu is expanded in the default, enabled, non-toggled state.
    abstract rootExpanded: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, enabled state
    abstract rootCheckedHovered: IStyle option with get, set
    /// Style override applied to the root on pressed in a checked, enabled state
    abstract rootCheckedPressed: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, disabled state
    abstract rootCheckedDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in a expanded state on hover
    abstract rootExpandedHovered: IStyle option with get, set
    /// Style for the flexbox container within the root element.
    abstract flexContainer: IStyle option with get, set
    /// Style for the text container within the flexbox container element (and contains the text and description).
    abstract textContainer: IStyle option with get, set
    /// Style for the icon on the near side of the label.
    abstract icon: IStyle option with get, set
    /// Style for the icon on the near side of the label on hover.
    abstract iconHovered: IStyle option with get, set
    /// Style for the icon on the near side of the label when pressed.
    abstract iconPressed: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded.
    abstract iconExpanded: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded and hovered.
    abstract iconExpandedHovered: IStyle option with get, set
    /// Style override for the icon when the button is disabled.
    abstract iconDisabled: IStyle option with get, set
    /// Style override for the icon when the button is checked.
    abstract iconChecked: IStyle option with get, set
    /// Style for the text content of the button.
    abstract label: IStyle option with get, set
    /// Style override for the text content when the button is disabled.
    abstract labelDisabled: IStyle option with get, set
    /// Style override for the text content when the button is checked.
    abstract labelChecked: IStyle option with get, set
    /// Style for the menu chevron.
    abstract menuIcon: IStyle option with get, set
    /// Style for the menu chevron on hover.
    abstract menuIconHovered: IStyle option with get, set
    /// Style for the menu chevron when pressed.
    abstract menuIconPressed: IStyle option with get, set
    /// Style for the menu chevron when expanded.
    abstract menuIconExpanded: IStyle option with get, set
    /// Style for the menu chevron when expanded and hovered.
    abstract menuIconExpandedHovered: IStyle option with get, set
    /// Style override for the menu chevron when the button is disabled.
    abstract menuIconDisabled: IStyle option with get, set
    /// Style override for the menu chevron when the button is checked.
    abstract menuIconChecked: IStyle option with get, set
    /// Style for the description text if applicable (for compound buttons.)
    abstract description: IStyle option with get, set
    /// Style override for the description text when the button is hovered.
    abstract descriptionHovered: IStyle option with get, set
    /// Style for the description text when the button is pressed.
    abstract descriptionPressed: IStyle option with get, set
    /// Style override for the description text when the button is disabled.
    abstract descriptionDisabled: IStyle option with get, set
    /// Style override for the description text when the button is checked.
    abstract descriptionChecked: IStyle option with get, set
    /// Style override for the screen reader text.
    abstract screenReaderText: IStyle option with get, set
    /// Style override for the container div around a SplitButton element
    abstract splitButtonContainer: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is hovered.
    abstract splitButtonContainerHovered: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is focused.
    abstract splitButtonContainerFocused: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked.
    abstract splitButtonContainerChecked: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked and hovered.
    abstract splitButtonContainerCheckedHovered: IStyle option with get, set
    /// Style override for the container div around a SplitButton element in a disabled state
    abstract splitButtonContainerDisabled: IStyle option with get, set
    /// Style override for the divider element that appears between the button and menu button
    /// for a split button.
    abstract splitButtonDivider: IStyle option with get, set
    /// Style override for the SplitButton menu button
    abstract splitButtonMenuButton: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a disabled state.
    abstract splitButtonMenuButtonDisabled: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a checked state
    abstract splitButtonMenuButtonChecked: IStyle option with get, set
    /// Style override for the SplitButton menu button element in an expanded state
    abstract splitButtonMenuButtonExpanded: IStyle option with get, set
    /// Style override for the SplitButton menu icon element
    abstract splitButtonMenuIcon: IStyle option with get, set
    /// Style override for the SplitButton menu icon element in a disabled state
    abstract splitButtonMenuIconDisabled: IStyle option with get, set
    /// Style override for the SplitButton FlexContainer.
    abstract splitButtonFlexContainer: IStyle option with get, set

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] Button =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] ButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IButtonProps -> Button

type [<AllowNullLiteral>] ActionButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] ActionButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ActionButton

type [<AllowNullLiteral>] CommandBarButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CommandBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CommandBarButton

type [<AllowNullLiteral>] CompoundButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CompoundButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CompoundButton

type [<AllowNullLiteral>] DefaultButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DefaultButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DefaultButton

type [<AllowNullLiteral>] MessageBarButton =
    inherit BaseComponent<IButtonProps, obj>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] MessageBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> MessageBarButton

type [<AllowNullLiteral>] PrimaryButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] PrimaryButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> PrimaryButton

type [<AllowNullLiteral>] IconButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] IconButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> IconButton
type BaseComponent = ______Utilities.BaseComponent
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IButtonProps = __Button_types.IButtonProps
type IButton = __Button_types.IButton
type BaseButton = __BaseButton.BaseButton
type Button = __Button.Button
type IButtonClassNames = __BaseButton_classNames.IButtonClassNames
type ISplitButtonClassNames = __SplitButton_SplitButton_classNames.ISplitButtonClassNames
type IRenderFunction = ______Utilities.IRenderFunction
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IIconProps = ______Icon.IIconProps
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type BaseComponent = ______Utilities.BaseComponent
type IButtonProps = __Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract BaseButton: BaseButtonStatic
    abstract Button: ButtonStatic
    abstract ActionButton: ActionButtonStatic
    abstract CommandBarButton: CommandBarButtonStatic
    abstract CompoundButton: CompoundButtonStatic
    abstract DefaultButton: DefaultButtonStatic
    abstract MessageBarButton: MessageBarButtonStatic
    abstract PrimaryButton: PrimaryButtonStatic
    abstract IconButton: IconButtonStatic

type [<AllowNullLiteral>] IBaseButtonProps =
    inherit IButtonProps
    abstract baseClassName: string option with get, set
    abstract variantClassName: string option with get, set

type [<AllowNullLiteral>] IBaseButtonState =
    abstract menuProps: IContextualMenuProps option option with get, set

type [<AllowNullLiteral>] BaseButton =
    inherit BaseComponent<IBaseButtonProps, IBaseButtonState>
    inherit IButton
    abstract _isSplitButton: obj
    abstract _isExpanded: obj
    abstract defaultProps: obj with get, set
    abstract _buttonElement: obj with get, set
    abstract _splitButtonContainer: obj with get, set
    abstract _labelId: obj with get, set
    abstract _descriptionId: obj with get, set
    abstract _ariaDescriptionId: obj with get, set
    abstract _classNames: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidUpdate: prevProps: IBaseButtonProps * prevState: IBaseButtonState -> unit
    abstract focus: unit -> unit
    abstract dismissMenu: unit -> unit
    abstract _onRenderContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderIcon: ?buttonProps: obj * ?defaultRender: obj -> unit
    abstract _onRenderTextContents: unit -> unit
    abstract _onRenderText: unit -> unit
    abstract _onRenderChildren: unit -> unit
    abstract _onRenderDescription: props: obj -> unit
    abstract _onRenderAriaDescription: unit -> unit
    abstract _onRenderMenuIcon: props: obj -> unit
    abstract _onRenderMenu: menuProps: obj -> unit
    abstract _dismissMenu: unit -> unit
    abstract _onToggleMenu: unit -> unit
    abstract _onRenderSplitButtonContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderSplitButtonDivider: classNames: obj -> unit
    abstract _onRenderSplitButtonMenuButton: classNames: obj -> unit
    abstract _onMouseDown: ev: obj -> unit
    abstract _onMenuKeyDown: ev: obj -> unit
    abstract _onMenuClick: ev: obj -> unit

type [<AllowNullLiteral>] BaseButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IBaseButtonProps * rootClassName: string -> BaseButton

type [<AllowNullLiteral>] IButton =
    /// Sets focus to the button.
    abstract focus: (unit -> unit) with get, set
    /// If there is a menu associated with this button and it is visible, this will dismiss the menu
    abstract dismissMenu: (unit -> unit) with get, set

type [<AllowNullLiteral>] IButtonProps =
    inherit React.AllHTMLAttributes<U4<HTMLAnchorElement, HTMLButtonElement, BaseButton, Button>>
    /// Optional callback to access the IButton interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IButton -> unit) option with get, set
    /// If provided, this component will be rendered as an anchor.
    abstract href: string option with get, set
    /// Changes the visual presentation of the button to be emphasized (if defined)
    abstract primary: bool option with get, set
    /// Unique id to identify the item. Typically a duplicate of key value.
    abstract uniqueId: U2<string, float> option with get, set
    /// Whether the button is disabled
    abstract disabled: bool option with get, set
    /// If set to true and if this is a splitButton (split == true) then the primary action of a split button is disabled.
    abstract primaryDisabled: bool option with get, set
    /// Custom styling for individual elements within the button DOM.
    abstract styles: IButtonStyles option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Whether the button is checked
    abstract ``checked``: bool option with get, set
    /// If provided, additional class name to provide on the root element.
    abstract className: string option with get, set
    /// The aria label of the button for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// Detailed description of the button for the benefit of screen readers.
    /// 
    /// Besides the compound button, other button types will need more information provided to screen reader.
    abstract ariaDescription: string option with get, set
    /// If provided and is true it adds an 'aria-hidden' attribute instructing screen readers to ignore the element.
    abstract ariaHidden: bool option with get, set
    /// Text to render button label. If text is supplied, it will override any string in button children. Other children components will be passed through after the text.
    abstract text: string option with get, set
    /// The props for the icon shown in the button.
    abstract iconProps: IIconProps option with get, set
    /// Props for button menu. Providing this will default to showing the menu icon. See menuIconProps for overriding
    /// how the default icon looks. Providing this in addition of onClick and setting the split property to true will render a SplitButton.
    abstract menuProps: IContextualMenuProps option with get, set
    /// Callback that runs after Button's contextualmenu was closed (removed from the DOM)
    abstract onAfterMenuDismiss: (unit -> unit) option with get, set
    /// If set to true, and if menuProps and onClick are provided, the button will render as a SplitButton. Defaults to false.
    abstract split: bool option with get, set
    /// The props for the icon shown when providing a menu dropdown.
    abstract menuIconProps: IIconProps option with get, set
    /// Accessible label for the dropdown chevron button if this button is split.
    abstract splitButtonAriaLabel: string option with get, set
    /// Optional callback when menu is clicked.
    abstract onMenuClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IButtonProps -> unit) option with get, set
    /// Custom render function for the icon
    abstract onRenderIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the label text.
    abstract onRenderText: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the desciption text.
    abstract onRenderDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the aria description element.
    abstract onRenderAriaDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for rendering the button children.
    abstract onRenderChildren: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu icon
    abstract onRenderMenuIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu
    abstract onRenderMenu: IRenderFunction<IContextualMenuProps> option with get, set
    /// Description of the action this button takes.
    /// Only used for compound buttons
    abstract description: string option with get, set
    /// Deprecated at v1.2.3, to be removed at >= v2.0.0. Use specific button component instead
    abstract buttonType: ButtonType option with get, set
    /// Deprecated at v0.56.2, to be removed at >= v1.0.0. Just pass in button props instead;
    /// they will be mixed into the button/anchor element rendered by the component.
    abstract rootProps: U2<React.ButtonHTMLAttributes<HTMLButtonElement>, React.AnchorHTMLAttributes<HTMLAnchorElement>> option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract toggled: bool option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract data: obj option option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getClassNames: (ITheme -> string -> string -> string option -> string option -> bool -> bool -> bool -> bool option -> IButtonClassNames) option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getSplitButtonClassNames: (bool -> bool -> bool -> ISplitButtonClassNames) option with get, set

type [<RequireQualifiedAccess>] ElementType =
    | Button = 0
    | Anchor = 1

type [<RequireQualifiedAccess>] ButtonType =
    | Normal = 0
    | Primary = 1
    | Hero = 2
    | Compound = 3
    | Command = 4
    | Icon = 5
    | Default = 6

type [<AllowNullLiteral>] IButtonStyles =
    /// Style for the root element in the default enabled, non-toggled state.
    abstract root: IStyle option with get, set
    /// Style override for the root element in a checked state, layered on top of the root style.
    abstract rootChecked: IStyle option with get, set
    /// Style override for the root element in a disabled state, layered on top of the root style.
    abstract rootDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootHovered: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootFocused: IStyle option with get, set
    /// Style override applied to the root on pressed in the default, enabled, non-toggled state.
    abstract rootPressed: IStyle option with get, set
    /// Style override applied to the root on when menu is expanded in the default, enabled, non-toggled state.
    abstract rootExpanded: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, enabled state
    abstract rootCheckedHovered: IStyle option with get, set
    /// Style override applied to the root on pressed in a checked, enabled state
    abstract rootCheckedPressed: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, disabled state
    abstract rootCheckedDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in a expanded state on hover
    abstract rootExpandedHovered: IStyle option with get, set
    /// Style for the flexbox container within the root element.
    abstract flexContainer: IStyle option with get, set
    /// Style for the text container within the flexbox container element (and contains the text and description).
    abstract textContainer: IStyle option with get, set
    /// Style for the icon on the near side of the label.
    abstract icon: IStyle option with get, set
    /// Style for the icon on the near side of the label on hover.
    abstract iconHovered: IStyle option with get, set
    /// Style for the icon on the near side of the label when pressed.
    abstract iconPressed: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded.
    abstract iconExpanded: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded and hovered.
    abstract iconExpandedHovered: IStyle option with get, set
    /// Style override for the icon when the button is disabled.
    abstract iconDisabled: IStyle option with get, set
    /// Style override for the icon when the button is checked.
    abstract iconChecked: IStyle option with get, set
    /// Style for the text content of the button.
    abstract label: IStyle option with get, set
    /// Style override for the text content when the button is disabled.
    abstract labelDisabled: IStyle option with get, set
    /// Style override for the text content when the button is checked.
    abstract labelChecked: IStyle option with get, set
    /// Style for the menu chevron.
    abstract menuIcon: IStyle option with get, set
    /// Style for the menu chevron on hover.
    abstract menuIconHovered: IStyle option with get, set
    /// Style for the menu chevron when pressed.
    abstract menuIconPressed: IStyle option with get, set
    /// Style for the menu chevron when expanded.
    abstract menuIconExpanded: IStyle option with get, set
    /// Style for the menu chevron when expanded and hovered.
    abstract menuIconExpandedHovered: IStyle option with get, set
    /// Style override for the menu chevron when the button is disabled.
    abstract menuIconDisabled: IStyle option with get, set
    /// Style override for the menu chevron when the button is checked.
    abstract menuIconChecked: IStyle option with get, set
    /// Style for the description text if applicable (for compound buttons.)
    abstract description: IStyle option with get, set
    /// Style override for the description text when the button is hovered.
    abstract descriptionHovered: IStyle option with get, set
    /// Style for the description text when the button is pressed.
    abstract descriptionPressed: IStyle option with get, set
    /// Style override for the description text when the button is disabled.
    abstract descriptionDisabled: IStyle option with get, set
    /// Style override for the description text when the button is checked.
    abstract descriptionChecked: IStyle option with get, set
    /// Style override for the screen reader text.
    abstract screenReaderText: IStyle option with get, set
    /// Style override for the container div around a SplitButton element
    abstract splitButtonContainer: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is hovered.
    abstract splitButtonContainerHovered: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is focused.
    abstract splitButtonContainerFocused: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked.
    abstract splitButtonContainerChecked: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked and hovered.
    abstract splitButtonContainerCheckedHovered: IStyle option with get, set
    /// Style override for the container div around a SplitButton element in a disabled state
    abstract splitButtonContainerDisabled: IStyle option with get, set
    /// Style override for the divider element that appears between the button and menu button
    /// for a split button.
    abstract splitButtonDivider: IStyle option with get, set
    /// Style override for the SplitButton menu button
    abstract splitButtonMenuButton: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a disabled state.
    abstract splitButtonMenuButtonDisabled: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a checked state
    abstract splitButtonMenuButtonChecked: IStyle option with get, set
    /// Style override for the SplitButton menu button element in an expanded state
    abstract splitButtonMenuButtonExpanded: IStyle option with get, set
    /// Style override for the SplitButton menu icon element
    abstract splitButtonMenuIcon: IStyle option with get, set
    /// Style override for the SplitButton menu icon element in a disabled state
    abstract splitButtonMenuIconDisabled: IStyle option with get, set
    /// Style override for the SplitButton FlexContainer.
    abstract splitButtonFlexContainer: IStyle option with get, set

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] Button =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] ButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IButtonProps -> Button

type [<AllowNullLiteral>] ActionButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] ActionButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ActionButton

type [<AllowNullLiteral>] CommandBarButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CommandBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CommandBarButton

type [<AllowNullLiteral>] CompoundButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CompoundButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CompoundButton

type [<AllowNullLiteral>] DefaultButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DefaultButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DefaultButton

type [<AllowNullLiteral>] MessageBarButton =
    inherit BaseComponent<IButtonProps, obj>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] MessageBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> MessageBarButton

type [<AllowNullLiteral>] PrimaryButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] PrimaryButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> PrimaryButton

type [<AllowNullLiteral>] IconButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] IconButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> IconButton
type BaseComponent = ______Utilities.BaseComponent
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IButtonProps = __Button_types.IButtonProps
type IButton = __Button_types.IButton
type BaseButton = __BaseButton.BaseButton
type Button = __Button.Button
type IButtonClassNames = __BaseButton_classNames.IButtonClassNames
type ISplitButtonClassNames = __SplitButton_SplitButton_classNames.ISplitButtonClassNames
type IRenderFunction = ______Utilities.IRenderFunction
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IIconProps = ______Icon.IIconProps
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type BaseComponent = ______Utilities.BaseComponent
type IButtonProps = __Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract BaseButton: BaseButtonStatic
    abstract Button: ButtonStatic
    abstract ActionButton: ActionButtonStatic
    abstract CommandBarButton: CommandBarButtonStatic
    abstract CompoundButton: CompoundButtonStatic
    abstract DefaultButton: DefaultButtonStatic
    abstract MessageBarButton: MessageBarButtonStatic
    abstract PrimaryButton: PrimaryButtonStatic
    abstract IconButton: IconButtonStatic

type [<AllowNullLiteral>] IBaseButtonProps =
    inherit IButtonProps
    abstract baseClassName: string option with get, set
    abstract variantClassName: string option with get, set

type [<AllowNullLiteral>] IBaseButtonState =
    abstract menuProps: IContextualMenuProps option option with get, set

type [<AllowNullLiteral>] BaseButton =
    inherit BaseComponent<IBaseButtonProps, IBaseButtonState>
    inherit IButton
    abstract _isSplitButton: obj
    abstract _isExpanded: obj
    abstract defaultProps: obj with get, set
    abstract _buttonElement: obj with get, set
    abstract _splitButtonContainer: obj with get, set
    abstract _labelId: obj with get, set
    abstract _descriptionId: obj with get, set
    abstract _ariaDescriptionId: obj with get, set
    abstract _classNames: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidUpdate: prevProps: IBaseButtonProps * prevState: IBaseButtonState -> unit
    abstract focus: unit -> unit
    abstract dismissMenu: unit -> unit
    abstract _onRenderContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderIcon: ?buttonProps: obj * ?defaultRender: obj -> unit
    abstract _onRenderTextContents: unit -> unit
    abstract _onRenderText: unit -> unit
    abstract _onRenderChildren: unit -> unit
    abstract _onRenderDescription: props: obj -> unit
    abstract _onRenderAriaDescription: unit -> unit
    abstract _onRenderMenuIcon: props: obj -> unit
    abstract _onRenderMenu: menuProps: obj -> unit
    abstract _dismissMenu: unit -> unit
    abstract _onToggleMenu: unit -> unit
    abstract _onRenderSplitButtonContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderSplitButtonDivider: classNames: obj -> unit
    abstract _onRenderSplitButtonMenuButton: classNames: obj -> unit
    abstract _onMouseDown: ev: obj -> unit
    abstract _onMenuKeyDown: ev: obj -> unit
    abstract _onMenuClick: ev: obj -> unit

type [<AllowNullLiteral>] BaseButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IBaseButtonProps * rootClassName: string -> BaseButton

type [<AllowNullLiteral>] IButton =
    /// Sets focus to the button.
    abstract focus: (unit -> unit) with get, set
    /// If there is a menu associated with this button and it is visible, this will dismiss the menu
    abstract dismissMenu: (unit -> unit) with get, set

type [<AllowNullLiteral>] IButtonProps =
    inherit React.AllHTMLAttributes<U4<HTMLAnchorElement, HTMLButtonElement, BaseButton, Button>>
    /// Optional callback to access the IButton interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IButton -> unit) option with get, set
    /// If provided, this component will be rendered as an anchor.
    abstract href: string option with get, set
    /// Changes the visual presentation of the button to be emphasized (if defined)
    abstract primary: bool option with get, set
    /// Unique id to identify the item. Typically a duplicate of key value.
    abstract uniqueId: U2<string, float> option with get, set
    /// Whether the button is disabled
    abstract disabled: bool option with get, set
    /// If set to true and if this is a splitButton (split == true) then the primary action of a split button is disabled.
    abstract primaryDisabled: bool option with get, set
    /// Custom styling for individual elements within the button DOM.
    abstract styles: IButtonStyles option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Whether the button is checked
    abstract ``checked``: bool option with get, set
    /// If provided, additional class name to provide on the root element.
    abstract className: string option with get, set
    /// The aria label of the button for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// Detailed description of the button for the benefit of screen readers.
    /// 
    /// Besides the compound button, other button types will need more information provided to screen reader.
    abstract ariaDescription: string option with get, set
    /// If provided and is true it adds an 'aria-hidden' attribute instructing screen readers to ignore the element.
    abstract ariaHidden: bool option with get, set
    /// Text to render button label. If text is supplied, it will override any string in button children. Other children components will be passed through after the text.
    abstract text: string option with get, set
    /// The props for the icon shown in the button.
    abstract iconProps: IIconProps option with get, set
    /// Props for button menu. Providing this will default to showing the menu icon. See menuIconProps for overriding
    /// how the default icon looks. Providing this in addition of onClick and setting the split property to true will render a SplitButton.
    abstract menuProps: IContextualMenuProps option with get, set
    /// Callback that runs after Button's contextualmenu was closed (removed from the DOM)
    abstract onAfterMenuDismiss: (unit -> unit) option with get, set
    /// If set to true, and if menuProps and onClick are provided, the button will render as a SplitButton. Defaults to false.
    abstract split: bool option with get, set
    /// The props for the icon shown when providing a menu dropdown.
    abstract menuIconProps: IIconProps option with get, set
    /// Accessible label for the dropdown chevron button if this button is split.
    abstract splitButtonAriaLabel: string option with get, set
    /// Optional callback when menu is clicked.
    abstract onMenuClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IButtonProps -> unit) option with get, set
    /// Custom render function for the icon
    abstract onRenderIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the label text.
    abstract onRenderText: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the desciption text.
    abstract onRenderDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the aria description element.
    abstract onRenderAriaDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for rendering the button children.
    abstract onRenderChildren: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu icon
    abstract onRenderMenuIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu
    abstract onRenderMenu: IRenderFunction<IContextualMenuProps> option with get, set
    /// Description of the action this button takes.
    /// Only used for compound buttons
    abstract description: string option with get, set
    /// Deprecated at v1.2.3, to be removed at >= v2.0.0. Use specific button component instead
    abstract buttonType: ButtonType option with get, set
    /// Deprecated at v0.56.2, to be removed at >= v1.0.0. Just pass in button props instead;
    /// they will be mixed into the button/anchor element rendered by the component.
    abstract rootProps: U2<React.ButtonHTMLAttributes<HTMLButtonElement>, React.AnchorHTMLAttributes<HTMLAnchorElement>> option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract toggled: bool option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract data: obj option option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getClassNames: (ITheme -> string -> string -> string option -> string option -> bool -> bool -> bool -> bool option -> IButtonClassNames) option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getSplitButtonClassNames: (bool -> bool -> bool -> ISplitButtonClassNames) option with get, set

type [<RequireQualifiedAccess>] ElementType =
    | Button = 0
    | Anchor = 1

type [<RequireQualifiedAccess>] ButtonType =
    | Normal = 0
    | Primary = 1
    | Hero = 2
    | Compound = 3
    | Command = 4
    | Icon = 5
    | Default = 6

type [<AllowNullLiteral>] IButtonStyles =
    /// Style for the root element in the default enabled, non-toggled state.
    abstract root: IStyle option with get, set
    /// Style override for the root element in a checked state, layered on top of the root style.
    abstract rootChecked: IStyle option with get, set
    /// Style override for the root element in a disabled state, layered on top of the root style.
    abstract rootDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootHovered: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootFocused: IStyle option with get, set
    /// Style override applied to the root on pressed in the default, enabled, non-toggled state.
    abstract rootPressed: IStyle option with get, set
    /// Style override applied to the root on when menu is expanded in the default, enabled, non-toggled state.
    abstract rootExpanded: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, enabled state
    abstract rootCheckedHovered: IStyle option with get, set
    /// Style override applied to the root on pressed in a checked, enabled state
    abstract rootCheckedPressed: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, disabled state
    abstract rootCheckedDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in a expanded state on hover
    abstract rootExpandedHovered: IStyle option with get, set
    /// Style for the flexbox container within the root element.
    abstract flexContainer: IStyle option with get, set
    /// Style for the text container within the flexbox container element (and contains the text and description).
    abstract textContainer: IStyle option with get, set
    /// Style for the icon on the near side of the label.
    abstract icon: IStyle option with get, set
    /// Style for the icon on the near side of the label on hover.
    abstract iconHovered: IStyle option with get, set
    /// Style for the icon on the near side of the label when pressed.
    abstract iconPressed: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded.
    abstract iconExpanded: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded and hovered.
    abstract iconExpandedHovered: IStyle option with get, set
    /// Style override for the icon when the button is disabled.
    abstract iconDisabled: IStyle option with get, set
    /// Style override for the icon when the button is checked.
    abstract iconChecked: IStyle option with get, set
    /// Style for the text content of the button.
    abstract label: IStyle option with get, set
    /// Style override for the text content when the button is disabled.
    abstract labelDisabled: IStyle option with get, set
    /// Style override for the text content when the button is checked.
    abstract labelChecked: IStyle option with get, set
    /// Style for the menu chevron.
    abstract menuIcon: IStyle option with get, set
    /// Style for the menu chevron on hover.
    abstract menuIconHovered: IStyle option with get, set
    /// Style for the menu chevron when pressed.
    abstract menuIconPressed: IStyle option with get, set
    /// Style for the menu chevron when expanded.
    abstract menuIconExpanded: IStyle option with get, set
    /// Style for the menu chevron when expanded and hovered.
    abstract menuIconExpandedHovered: IStyle option with get, set
    /// Style override for the menu chevron when the button is disabled.
    abstract menuIconDisabled: IStyle option with get, set
    /// Style override for the menu chevron when the button is checked.
    abstract menuIconChecked: IStyle option with get, set
    /// Style for the description text if applicable (for compound buttons.)
    abstract description: IStyle option with get, set
    /// Style override for the description text when the button is hovered.
    abstract descriptionHovered: IStyle option with get, set
    /// Style for the description text when the button is pressed.
    abstract descriptionPressed: IStyle option with get, set
    /// Style override for the description text when the button is disabled.
    abstract descriptionDisabled: IStyle option with get, set
    /// Style override for the description text when the button is checked.
    abstract descriptionChecked: IStyle option with get, set
    /// Style override for the screen reader text.
    abstract screenReaderText: IStyle option with get, set
    /// Style override for the container div around a SplitButton element
    abstract splitButtonContainer: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is hovered.
    abstract splitButtonContainerHovered: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is focused.
    abstract splitButtonContainerFocused: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked.
    abstract splitButtonContainerChecked: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked and hovered.
    abstract splitButtonContainerCheckedHovered: IStyle option with get, set
    /// Style override for the container div around a SplitButton element in a disabled state
    abstract splitButtonContainerDisabled: IStyle option with get, set
    /// Style override for the divider element that appears between the button and menu button
    /// for a split button.
    abstract splitButtonDivider: IStyle option with get, set
    /// Style override for the SplitButton menu button
    abstract splitButtonMenuButton: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a disabled state.
    abstract splitButtonMenuButtonDisabled: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a checked state
    abstract splitButtonMenuButtonChecked: IStyle option with get, set
    /// Style override for the SplitButton menu button element in an expanded state
    abstract splitButtonMenuButtonExpanded: IStyle option with get, set
    /// Style override for the SplitButton menu icon element
    abstract splitButtonMenuIcon: IStyle option with get, set
    /// Style override for the SplitButton menu icon element in a disabled state
    abstract splitButtonMenuIconDisabled: IStyle option with get, set
    /// Style override for the SplitButton FlexContainer.
    abstract splitButtonFlexContainer: IStyle option with get, set

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] Button =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] ButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IButtonProps -> Button

type [<AllowNullLiteral>] ActionButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] ActionButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ActionButton

type [<AllowNullLiteral>] CommandBarButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CommandBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CommandBarButton

type [<AllowNullLiteral>] CompoundButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CompoundButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CompoundButton

type [<AllowNullLiteral>] DefaultButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DefaultButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DefaultButton

type [<AllowNullLiteral>] MessageBarButton =
    inherit BaseComponent<IButtonProps, obj>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] MessageBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> MessageBarButton

type [<AllowNullLiteral>] PrimaryButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] PrimaryButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> PrimaryButton

type [<AllowNullLiteral>] IconButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] IconButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> IconButton
type BaseComponent = ______Utilities.BaseComponent
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IButtonProps = __Button_types.IButtonProps
type IButton = __Button_types.IButton
type BaseButton = __BaseButton.BaseButton
type Button = __Button.Button
type IButtonClassNames = __BaseButton_classNames.IButtonClassNames
type ISplitButtonClassNames = __SplitButton_SplitButton_classNames.ISplitButtonClassNames
type IRenderFunction = ______Utilities.IRenderFunction
type IContextualMenuProps = ______ContextualMenu.IContextualMenuProps
type IIconProps = ______Icon.IIconProps
type IStyle = ______Styling.IStyle
type ITheme = ______Styling.ITheme
type BaseComponent = ______Utilities.BaseComponent
type IButtonProps = __Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type ActionButton = ___ActionButton_ActionButton.ActionButton
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
type BaseComponent = _________Utilities.BaseComponent
type IButtonProps = ___Button_types.IButtonProps
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative
let [<Import("*","office-ui-fabric-react")>] CommandButton: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract BaseButton: BaseButtonStatic
    abstract Button: ButtonStatic
    abstract ActionButton: ActionButtonStatic
    abstract CommandBarButton: CommandBarButtonStatic
    abstract CompoundButton: CompoundButtonStatic
    abstract DefaultButton: DefaultButtonStatic
    abstract MessageBarButton: MessageBarButtonStatic
    abstract PrimaryButton: PrimaryButtonStatic
    abstract IconButton: IconButtonStatic

type [<AllowNullLiteral>] IBaseButtonProps =
    inherit IButtonProps
    abstract baseClassName: string option with get, set
    abstract variantClassName: string option with get, set

type [<AllowNullLiteral>] IBaseButtonState =
    abstract menuProps: IContextualMenuProps option option with get, set

type [<AllowNullLiteral>] BaseButton =
    inherit BaseComponent<IBaseButtonProps, IBaseButtonState>
    inherit IButton
    abstract _isSplitButton: obj
    abstract _isExpanded: obj
    abstract defaultProps: obj with get, set
    abstract _buttonElement: obj with get, set
    abstract _splitButtonContainer: obj with get, set
    abstract _labelId: obj with get, set
    abstract _descriptionId: obj with get, set
    abstract _ariaDescriptionId: obj with get, set
    abstract _classNames: obj with get, set
    abstract render: unit -> JSX.Element
    abstract componentDidUpdate: prevProps: IBaseButtonProps * prevState: IBaseButtonState -> unit
    abstract focus: unit -> unit
    abstract dismissMenu: unit -> unit
    abstract _onRenderContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderIcon: ?buttonProps: obj * ?defaultRender: obj -> unit
    abstract _onRenderTextContents: unit -> unit
    abstract _onRenderText: unit -> unit
    abstract _onRenderChildren: unit -> unit
    abstract _onRenderDescription: props: obj -> unit
    abstract _onRenderAriaDescription: unit -> unit
    abstract _onRenderMenuIcon: props: obj -> unit
    abstract _onRenderMenu: menuProps: obj -> unit
    abstract _dismissMenu: unit -> unit
    abstract _onToggleMenu: unit -> unit
    abstract _onRenderSplitButtonContent: tag: obj * buttonProps: obj -> unit
    abstract _onRenderSplitButtonDivider: classNames: obj -> unit
    abstract _onRenderSplitButtonMenuButton: classNames: obj -> unit
    abstract _onMouseDown: ev: obj -> unit
    abstract _onMenuKeyDown: ev: obj -> unit
    abstract _onMenuClick: ev: obj -> unit

type [<AllowNullLiteral>] BaseButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IBaseButtonProps * rootClassName: string -> BaseButton

type [<AllowNullLiteral>] IButton =
    /// Sets focus to the button.
    abstract focus: (unit -> unit) with get, set
    /// If there is a menu associated with this button and it is visible, this will dismiss the menu
    abstract dismissMenu: (unit -> unit) with get, set

type [<AllowNullLiteral>] IButtonProps =
    inherit React.AllHTMLAttributes<U4<HTMLAnchorElement, HTMLButtonElement, BaseButton, Button>>
    /// Optional callback to access the IButton interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    abstract componentRef: (IButton -> unit) option with get, set
    /// If provided, this component will be rendered as an anchor.
    abstract href: string option with get, set
    /// Changes the visual presentation of the button to be emphasized (if defined)
    abstract primary: bool option with get, set
    /// Unique id to identify the item. Typically a duplicate of key value.
    abstract uniqueId: U2<string, float> option with get, set
    /// Whether the button is disabled
    abstract disabled: bool option with get, set
    /// If set to true and if this is a splitButton (split == true) then the primary action of a split button is disabled.
    abstract primaryDisabled: bool option with get, set
    /// Custom styling for individual elements within the button DOM.
    abstract styles: IButtonStyles option with get, set
    /// Theme provided by HOC.
    abstract theme: ITheme option with get, set
    /// Whether the button is checked
    abstract ``checked``: bool option with get, set
    /// If provided, additional class name to provide on the root element.
    abstract className: string option with get, set
    /// The aria label of the button for the benefit of screen readers.
    abstract ariaLabel: string option with get, set
    /// Detailed description of the button for the benefit of screen readers.
    /// 
    /// Besides the compound button, other button types will need more information provided to screen reader.
    abstract ariaDescription: string option with get, set
    /// If provided and is true it adds an 'aria-hidden' attribute instructing screen readers to ignore the element.
    abstract ariaHidden: bool option with get, set
    /// Text to render button label. If text is supplied, it will override any string in button children. Other children components will be passed through after the text.
    abstract text: string option with get, set
    /// The props for the icon shown in the button.
    abstract iconProps: IIconProps option with get, set
    /// Props for button menu. Providing this will default to showing the menu icon. See menuIconProps for overriding
    /// how the default icon looks. Providing this in addition of onClick and setting the split property to true will render a SplitButton.
    abstract menuProps: IContextualMenuProps option with get, set
    /// Callback that runs after Button's contextualmenu was closed (removed from the DOM)
    abstract onAfterMenuDismiss: (unit -> unit) option with get, set
    /// If set to true, and if menuProps and onClick are provided, the button will render as a SplitButton. Defaults to false.
    abstract split: bool option with get, set
    /// The props for the icon shown when providing a menu dropdown.
    abstract menuIconProps: IIconProps option with get, set
    /// Accessible label for the dropdown chevron button if this button is split.
    abstract splitButtonAriaLabel: string option with get, set
    /// Optional callback when menu is clicked.
    abstract onMenuClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IButtonProps -> unit) option with get, set
    /// Custom render function for the icon
    abstract onRenderIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the label text.
    abstract onRenderText: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the desciption text.
    abstract onRenderDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for the aria description element.
    abstract onRenderAriaDescription: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for rendering the button children.
    abstract onRenderChildren: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu icon
    abstract onRenderMenuIcon: IRenderFunction<IButtonProps> option with get, set
    /// Custom render function for button menu
    abstract onRenderMenu: IRenderFunction<IContextualMenuProps> option with get, set
    /// Description of the action this button takes.
    /// Only used for compound buttons
    abstract description: string option with get, set
    /// Deprecated at v1.2.3, to be removed at >= v2.0.0. Use specific button component instead
    abstract buttonType: ButtonType option with get, set
    /// Deprecated at v0.56.2, to be removed at >= v1.0.0. Just pass in button props instead;
    /// they will be mixed into the button/anchor element rendered by the component.
    abstract rootProps: U2<React.ButtonHTMLAttributes<HTMLButtonElement>, React.AnchorHTMLAttributes<HTMLAnchorElement>> option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract toggled: bool option with get, set
    /// Any custom data the developer wishes to associate with the menu item.
    abstract data: obj option option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getClassNames: (ITheme -> string -> string -> string option -> string option -> bool -> bool -> bool -> bool option -> IButtonClassNames) option with get, set
    /// Method to provide the classnames to style a button.
    /// The default value for this prop is the getClassnames func
    /// defined in BaseButton.classnames.
    abstract getSplitButtonClassNames: (bool -> bool -> bool -> ISplitButtonClassNames) option with get, set

type [<RequireQualifiedAccess>] ElementType =
    | Button = 0
    | Anchor = 1

type [<RequireQualifiedAccess>] ButtonType =
    | Normal = 0
    | Primary = 1
    | Hero = 2
    | Compound = 3
    | Command = 4
    | Icon = 5
    | Default = 6

type [<AllowNullLiteral>] IButtonStyles =
    /// Style for the root element in the default enabled, non-toggled state.
    abstract root: IStyle option with get, set
    /// Style override for the root element in a checked state, layered on top of the root style.
    abstract rootChecked: IStyle option with get, set
    /// Style override for the root element in a disabled state, layered on top of the root style.
    abstract rootDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootHovered: IStyle option with get, set
    /// Style override applied to the root on hover in the default, enabled, non-toggled state.
    abstract rootFocused: IStyle option with get, set
    /// Style override applied to the root on pressed in the default, enabled, non-toggled state.
    abstract rootPressed: IStyle option with get, set
    /// Style override applied to the root on when menu is expanded in the default, enabled, non-toggled state.
    abstract rootExpanded: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, enabled state
    abstract rootCheckedHovered: IStyle option with get, set
    /// Style override applied to the root on pressed in a checked, enabled state
    abstract rootCheckedPressed: IStyle option with get, set
    /// Style override applied to the root on hover in a checked, disabled state
    abstract rootCheckedDisabled: IStyle option with get, set
    /// Style override applied to the root on hover in a expanded state on hover
    abstract rootExpandedHovered: IStyle option with get, set
    /// Style for the flexbox container within the root element.
    abstract flexContainer: IStyle option with get, set
    /// Style for the text container within the flexbox container element (and contains the text and description).
    abstract textContainer: IStyle option with get, set
    /// Style for the icon on the near side of the label.
    abstract icon: IStyle option with get, set
    /// Style for the icon on the near side of the label on hover.
    abstract iconHovered: IStyle option with get, set
    /// Style for the icon on the near side of the label when pressed.
    abstract iconPressed: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded.
    abstract iconExpanded: IStyle option with get, set
    /// Style for the icon on the near side of the label when expanded and hovered.
    abstract iconExpandedHovered: IStyle option with get, set
    /// Style override for the icon when the button is disabled.
    abstract iconDisabled: IStyle option with get, set
    /// Style override for the icon when the button is checked.
    abstract iconChecked: IStyle option with get, set
    /// Style for the text content of the button.
    abstract label: IStyle option with get, set
    /// Style override for the text content when the button is disabled.
    abstract labelDisabled: IStyle option with get, set
    /// Style override for the text content when the button is checked.
    abstract labelChecked: IStyle option with get, set
    /// Style for the menu chevron.
    abstract menuIcon: IStyle option with get, set
    /// Style for the menu chevron on hover.
    abstract menuIconHovered: IStyle option with get, set
    /// Style for the menu chevron when pressed.
    abstract menuIconPressed: IStyle option with get, set
    /// Style for the menu chevron when expanded.
    abstract menuIconExpanded: IStyle option with get, set
    /// Style for the menu chevron when expanded and hovered.
    abstract menuIconExpandedHovered: IStyle option with get, set
    /// Style override for the menu chevron when the button is disabled.
    abstract menuIconDisabled: IStyle option with get, set
    /// Style override for the menu chevron when the button is checked.
    abstract menuIconChecked: IStyle option with get, set
    /// Style for the description text if applicable (for compound buttons.)
    abstract description: IStyle option with get, set
    /// Style override for the description text when the button is hovered.
    abstract descriptionHovered: IStyle option with get, set
    /// Style for the description text when the button is pressed.
    abstract descriptionPressed: IStyle option with get, set
    /// Style override for the description text when the button is disabled.
    abstract descriptionDisabled: IStyle option with get, set
    /// Style override for the description text when the button is checked.
    abstract descriptionChecked: IStyle option with get, set
    /// Style override for the screen reader text.
    abstract screenReaderText: IStyle option with get, set
    /// Style override for the container div around a SplitButton element
    abstract splitButtonContainer: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is hovered.
    abstract splitButtonContainerHovered: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is focused.
    abstract splitButtonContainerFocused: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked.
    abstract splitButtonContainerChecked: IStyle option with get, set
    /// Style for container div around a SplitButton element when the button is checked and hovered.
    abstract splitButtonContainerCheckedHovered: IStyle option with get, set
    /// Style override for the container div around a SplitButton element in a disabled state
    abstract splitButtonContainerDisabled: IStyle option with get, set
    /// Style override for the divider element that appears between the button and menu button
    /// for a split button.
    abstract splitButtonDivider: IStyle option with get, set
    /// Style override for the SplitButton menu button
    abstract splitButtonMenuButton: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a disabled state.
    abstract splitButtonMenuButtonDisabled: IStyle option with get, set
    /// Style override for the SplitButton menu button element in a checked state
    abstract splitButtonMenuButtonChecked: IStyle option with get, set
    /// Style override for the SplitButton menu button element in an expanded state
    abstract splitButtonMenuButtonExpanded: IStyle option with get, set
    /// Style override for the SplitButton menu icon element
    abstract splitButtonMenuIcon: IStyle option with get, set
    /// Style override for the SplitButton menu icon element in a disabled state
    abstract splitButtonMenuIconDisabled: IStyle option with get, set
    /// Style override for the SplitButton FlexContainer.
    abstract splitButtonFlexContainer: IStyle option with get, set

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] Button =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

/// This class is deprecated. Use the individual *Button components instead.
type [<AllowNullLiteral>] ButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: props: IButtonProps -> Button

type [<AllowNullLiteral>] ActionButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] ActionButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> ActionButton

type [<AllowNullLiteral>] CommandBarButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CommandBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CommandBarButton

type [<AllowNullLiteral>] CompoundButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] CompoundButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> CompoundButton

type [<AllowNullLiteral>] DefaultButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] DefaultButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> DefaultButton

type [<AllowNullLiteral>] MessageBarButton =
    inherit BaseComponent<IButtonProps, obj>
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] MessageBarButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> MessageBarButton

type [<AllowNullLiteral>] PrimaryButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] PrimaryButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> PrimaryButton

type [<AllowNullLiteral>] IconButton =
    inherit BaseComponent<IButtonProps, obj>
    /// Tell BaseComponent to bypass resolution of componentRef.
    abstract _shouldUpdateComponentRef: bool with get, set
    abstract render: unit -> JSX.Element

type [<AllowNullLiteral>] IconButtonStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> IconButton
