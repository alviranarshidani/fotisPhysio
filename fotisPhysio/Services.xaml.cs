using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fotisPhysio
{
    public partial class Services : ContentPage
    {
        String Service_Title;
        String description;
        public Services()
        {
            InitializeComponent();
        }

     public async  void Sports_Orthopaedic_Physiotherapy(object sender, System.EventArgs e)
        {
            Service_Title = "Sports Orthopaedic Physiotherap";

            description = "Physiotherapist’s works with you to provide Quality care to restore person’s abilities to move and perform functional activities in their daily live. They are skilled in providing treatment, preventative advice, rehabilitation and care for people with short or long-term impairments and will develop a full treatment plan to suit your unique needs and to lead you to self-management.What can I expect at my first physiotherapy visit?On your initial visit, your physiotherapist will assess your specific condition. A detailed history of your injury will be taken and a full musculoskeletal examination will be performed. A clinical diagnosis will then be established to identify and appropriately treat your condition. Based on your assessment, individual goals will be created with you, and a specific physiotherapeutic treatment plan will be initiated.What Can The Treatment Involve?Your therapist may also use various modalities to speed your recovery and decrease pain.Any one or a combination of the following modalities used may include:Manual therapy – hands-on stretching and mobilization ";
            await Navigation.PushAsync(new ServicesPart1(Service_Title,description));
        }
        public async void Chiropractic(object sender, System.EventArgs e)
        {
            Service_Title = "Chiropractic";
            description = "Chiropractic is an evidence-informed, non-invasive, hands-on health care discipline that focuses on the musculoskeletal system.\n\nChiropractors practice primarily using their hands, providing diagnosis, treatment and preventive care for disorders related to the spine, pelvis, nervous system and joints.Chiropractors use a combination of treatments, depending on the specific needs of the individual patient. After taking a history, performing an examination and establishing a diagnosis, a chiropractor can develop and carry out a comprehensive treatment/management plan, recommend therapeutic exercise and other non-invasive therapies, and provide nutritional, dietary and lifestyle counselling.One of the most common therapies a chiropractor uses is spinal manipulative therapy (SMT), which can comprise a variety of adjustment techniques. Specific training in SMT allows chiropractors to provide highly-skilled and precise adjustments to the vertebrae of the spine, correcting joint motion to restore proper movement and improve function.For many conditions, such as low back pain. ";
            await Navigation.PushAsync(new ServicesPart1(Service_Title,description));
        }
        public async void Massage_Therapy(object sender, System.EventArgs e)
        {
            Service_Title = "Massage Therapy";
            description = "Massage therapy encompasses many different techniques. In general, therapists press, rub, and otherwise manipulate the muscles and other soft tissues of the body. They most often use their hands and fingers but may use their forearms, elbows, or feet.The term “massage therapy” includes many techniques, and the type of massage given usually depends on your needs and physical condition.Massage therapy dates back thousands of years. References to massage appear in ancient writings from China, Japan, India, and Egypt.In general, massage therapists work on muscle and other soft tissue to help you feel better.In Swedish massage, the therapist uses long strokes, kneading, deep circular movements, vibration, and tapping.Sports massage combines techniques of Swedish massage and deep tissue massage to release chronic muscle tension. It’s adapted to the needs of athletes.Myofascial trigger point therapy focuses on trigger points—areas that are painful when pressed and are associated with pain elsewhere in the body.Massage therapy is sometimes done using essential oils ";
            await Navigation.PushAsync(new ServicesPart1(Service_Title,description));
        }
        public async void Acupuncture(object sender, System.EventArgs e)
        {
            Service_Title = "Acupuncture";
            description = "Acupuncture is a therapeutic method used to promote healing, reduce pain and improve function. Acupuncture involves the insertion of very fine needles through the skin and tissues at various points in the body. There is significant research that supports the effectiveness and safety of Acupuncture. When used by a skilled Physiotherapist in combination with knowledge of anatomy, physiology and pathophysiology, Acupuncture can be a very effective therapeutic tool.Our Physiotherapists at Fotis Physio & Wellness Clinic are trained and certified by the Acupuncture course at McMaster.How does Acupuncture work?Acupuncture stimulates the body to produce its own pain-relieving chemicals called “endorphins”. These chemicals can help block pain messages, improve general relaxation of tight muscles, and restore biochemical balance in the tissues. There is also thought to be a local response in the muscles stimulated by the needles, which involves increased blood flow, reduction of inflammation and reduction of tightness in the affected muscle.";
            await Navigation.PushAsync(new ServicesPart1(Service_Title,description));
        }
        public async void In_Home_Physio(object sender, System.EventArgs e)
        {
            Service_Title = "In-Home Physio";
            description = "Physiotherapist’s works with you to provide Quality care to restore person’s abilities to move and perform functional activities in their daily live. They are skilled in providing treatment, preventative advice, rehabilitation and care for people with short or long-term impairments and will develop a full treatment plan to suit your unique needs and to lead you to self-management.What can I expect at my first physiotherapy visit?On your initial visit, your physiotherapist will assess your specific condition. A detailed history of your injury will be taken and a full musculoskeletal examination will be performed. A clinical diagnosis will then be established to identify and appropriately treat your condition. Based on your assessment, individual goals will be created with you, and a specific physiotherapeutic treatment plan will be initiated.What Can The Treatment Involve?Your therapist may also use various modalities to speed your recovery and decrease pain.Any one or a combination of the following modalities used may include:Manual therapy – hands-on stretching and mobilization of muscles bones and joints";
            await Navigation.PushAsync(new ServicesPart1(Service_Title,description));
        }
        public async void Pelvic_Health_Therapy(object sender, System.EventArgs e)
        {
            Service_Title = "Pelvic Health Therapy";
            description = "pecialized Physiotherapy is becoming more established in the literature as a first-line of defence against Incontinence and Pelvic Pain. Pelvic Floor Dysfunction can be caused by:HYPOTONICITY (Weak pelvic floor muscles): contributing to stress incontinence, urge incontinence and pelvic organ prolapse. Incontinence is NOT a normal part of aging.HYPERTONICITY (Tight pelvic floor muscles): contributing to Urinary and Fecal Urgency, Urge Incontinence, Chronic Pelvic Pain, Dyspareunia, Vaginismus, Vulvodynia, Pudendal Neuralgia, Interstitial Cystitis and Chronic Prostatitis,medical accurate illustration of the hip ligamentsKegels are Not always indicated for pelvic floor problems. Sometimes they do more harm than good, and often they are NOT performed correctly.The Cochrane Collaboration 2010 concluded that Physiotherapists with specialized training in pelvic floor rehabilitation (using internal examination to teach the exercises) should be the first line of defence, before surgical consultation, for stress, urge and mixed incontinence in women.";
            await Navigation.PushAsync(new ServicesPart1(Service_Title,description));
        }
        public async void Motor_Vehicle_Accident_Rehab(object sender, System.EventArgs e)
        { 
            Service_Title = "Motor Vehicle Accident Rehab";
            description = "Seek treatment as soon as possible.If you are seriously hurt, go to the ER or local hospital. Be sure to ask for a physical therapy prescription, just in case you may need it.Don't have a doctor? We have a team of doctors who can see you and refer you to physical therapy at no out of pocket expense to you. Call us.If you still experiencing pain or discomfort a few days or more, come to our office to determine if you need further care.Remember, come in ASAP in order to get better, faster.Most Auto Insurance companies have what is called Med Pay or PIP. This means you are covered 100%, with no out of pocket expense up to a certain limit. Our office can check into that for you.If the accident was not your fault. The other party's auto insurance should cover your health care expenses in our office. We will do all of the paperwork for you.At the accident scene, gather as much information on the other driver or drivers as possible. An accident report by Police is always helpful, but not required to have a case.";
            await Navigation.PushAsync(new ServicesPart1(Service_Title,description));
        }   
    }
}
