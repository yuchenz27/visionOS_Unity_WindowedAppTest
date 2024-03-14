# visionOS_Unity_WindowedAppTest

This repository explores converting existing iOS apps into windowed apps on visionOS using Unity, focusing on the nuances of user interactions within such apps.

## Testing Target

We tested a simplistic iOS app that allows users to manipulate a floating cube by tapping or dragging across the screen. A dropdown menu in the top-left corner enables switching between the two interaction modes.

![ezgif-5-bb4e6a05e5](https://github.com/yuchenz27/visionOS_Unity_WindowedAppTest/assets/44870300/e83994d9-c5f9-4d6e-902a-5bf21699bebc)

## Testing Configuration

Converting the project for use on Apple Vision Pro requires merely switching the target platform from iOS to visionOS, with no additional package installations or setting adjustments needed.

<img src="https://github.com/yuchenz27/visionOS_Unity_WindowedAppTest/assets/44870300/66b85061-81ff-4f85-8873-c793c844610f" width="500">

## Testing Result

### General Observations

The application transitions smoothly into a visionOS window, allowing users to reposition and resize it within the shared space. Currently, window aspect ratio can be modified while resizing, though there may be a way to lock it.

![ezgif-6-edb1aa26c5](https://github.com/yuchenz27/visionOS_Unity_WindowedAppTest/assets/44870300/edd8244d-ddfe-4d25-8006-e11121c264df)

### Indirect Eye Pinch Interaction

Simulating screen taps through gaze targeting and pinching is functional but lacks visual feedback. There is no visual indication to confirm where the user is looking at on the screen.

![ezgif-2-06b2a6534e](https://github.com/yuchenz27/visionOS_Unity_WindowedAppTest/assets/44870300/563ea5bf-718c-4888-8603-d8d2f54c4f28)

The absence of a hover effect for UI elements complicates confident interaction, often leading to inadvertent selections.

![ezgif-2-fd173c7642](https://github.com/yuchenz27/visionOS_Unity_WindowedAppTest/assets/44870300/fed318ed-86f4-4d39-87e8-26fc76eca667)

However, using gaze and pinch gestures for dragging operations proves to be surprisingly smooth.

![ezgif-6-823313c1ee](https://github.com/yuchenz27/visionOS_Unity_WindowedAppTest/assets/44870300/8ad785e5-6e33-4a23-b0cd-8ac7af7efb2f)

### Direct Poking

Interacting directly with the virtual window mimics tapping on a smartphone's screen, offering a more reliable method of manipulation.

![ezgif-7-7d0f714e13](https://github.com/yuchenz27/visionOS_Unity_WindowedAppTest/assets/44870300/65a0fff2-6b2d-4b50-ab53-3365bdaa89c1)

This approach enhances UI operability compared to the indirect eye-hand method, which lacks any hover feedback.

![ezgif-2-3dce25d2bd](https://github.com/yuchenz27/visionOS_Unity_WindowedAppTest/assets/44870300/9d4624e0-7728-41b8-81c6-0baade8a7879)

Direct dragging gestures also perform well.

![ezgif-3-92192c6c02](https://github.com/yuchenz27/visionOS_Unity_WindowedAppTest/assets/44870300/5071e801-8a7b-47c1-abe9-b4a877a3f8d2)

## Conclusion

The primary problem with ported windowed apps on visionOS lies in the lack of feedback for eye-tracking, complicating the user of indirect eye pinch interactions. By positioning the window closer and interacting directly, the experience markedly improves, akin to using a virtual iPad with a larger screen.

However, the main advantage of porting iOS apps to visionOS is probably the expanded display size with a relatively far distance to the user, the indirect interaction mode poses significant usability challenges.
