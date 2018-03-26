# Telerik UI for Xamarin Training Materials
Presentation resources and demo materials for Telerik UI for Xamarin.

## Clone
```bash
git clone https://github.com/newventuresoftware/xamarin-training.git
cd xamarin-training
```

## Slides

Open slides/index.html in your browser or run the presentation on [RawGit](https://rawgit.com/newventuresoftware/xamarin-training/master/slides/index.html).

## Running the Demos

### Prerequisites

* [Visual Studio](https://www.visualstudio.com/downloads/) - you need Visual Studio for Windows or Mac in order to compile and run Xamarin projects. You can find a lot of information on how to setup your dev environment in the Telerik UI for Xamarin [documentation](https://docs.telerik.com/devtools/xamarin/installation-and-deployment/system-requirements). 
* [Android Studio](https://developer.android.com/studio/index.html) - we are going to use that for managing android SDK and virtual devices;
* [NodeJS](https://nodejs.org/en/) - (optional) used for downloading the dependencies and running the demo REST service. Not required for Xamarin development;

After installing NodeJS, you can start the demo REST service through `npm` (Node Package Manager). Enter in the `Command Prompt` the following command:

```bash
cd service
npm install
npm start
```

As this is a service running on your machine, you need to obtain your local network ip address and update the following constant:
```
namespace XTraining.Services
{
    public class NorthwindService : INorthwindService
    {
        ...
        private static string baseServiceUrl = "<your ip>:3000";
        ...
    }
}
```

### HelloXamarinNative

* Navigate to `\demos\complete\HelloXamarinNative`
* All the needed files are already included and referenced, so simply build the project (CTRL + SHIFT + B) to get it ready to run.

### XForms

* Navigate to `\demos\complete\XForms.Complete\XForms`
* Open `XForms.sln`
* A simple build is sufficient.

### XTraining

* Navigate to `\demos\complete\XTraining.Complete\XTraining`
* Open `XTraining.sln`
* A simple build is sufficient here as well.
* Use this [step-by-step tutorial](https://docs.telerik.com/devtools/xamarin/installation-and-deployment/windows/getting-started-windows) on how to build a Telerik UI for Xamarin project from scratch or how to integrate the Telerik UI suite in an already existing project.

## Terms & Conditions of Use

This project uses Telerik UI for Xamarin, which is commercial software. To use it, you need to agree to the [Telerik End User License Agreement for Telerik UI for Xamarin](https://www.telerik.com/purchase/license-agreement/ui-for-xamarin). If you do not own a commercial license, the files associated with the software shall be governed by the trial license terms.

All available Telerik UI for Xamarin commercial licenses may be obtained [here](https://www.telerik.com/purchase/xamarin-ui).