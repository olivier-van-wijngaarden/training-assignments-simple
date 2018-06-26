package eu.sig.training.ch05.buildandsendmail;

public class BuildAndSendMail {
    // tag::buildAndSendMail[]
    public MailMessage buildMail(MailFont font, String message1,
        String message2, String message3) {
        // Format the message given the content type and raw message
        return formatMessage(font, message1 + message2 + message3);
    }
    
    public void sendMail(MailMan m, String firstName, String lastName,
        String division, String subject, MailMessage message) {
        // Format the email address
        String mId = firstName.charAt(0) + "." + lastName.substring(0, 7) + "@"
            + division.substring(0, 5) + ".compa.ny";
        m.send(mId, subject, message);
    }
    // end::buildAndSendMail[]

    @SuppressWarnings("unused")
    private MailMessage formatMessage(MailFont font, String string) {
        return null;
    }

    private class MailMan {

        @SuppressWarnings("unused")
        public void send(String mId, String subject, MailMessage mMessage) {}

    }

    private class MailFont {

    }

    private class MailMessage {

    }

}