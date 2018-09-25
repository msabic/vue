<template>
    <div id="login">
        <label>Login</label>
        <input type="text" name="username" v-model="input.username" placeholder="Username" />
        <input type="password" name="password" v-model="input.password" placeholder="Password" />
        <button class="login_btn" type="button" v-on:click="login()">Login</button>
        <button class="singin_btn" type="button" v-on:click="login()">Singin</button>
    </div>
</template>

<script>
    export default {
        name: 'Login',
        data() {
            return {
                input: {
                    username: "",
                    password: ""
                }
            }
        },
        methods: {
            login() {
                if(this.input.username != "" && this.input.password != "") {
                    if(this.input.username == this.$parent.mockAccount.username && this.input.password == this.$parent.mockAccount.password) {
                        this.$emit("authenticated", true);
                        this.$router.replace({ name: "secure" });
                    } else {
                        console.log("The username and / or password is incorrect");
                    }
                } else {
                    console.log("A username and password must be present");
                        }
    }
                }
        }              
</script>

<style scoped>
    #login {
        width: 50%;
        height: 50%px;
        border: 1px solid #CCCCCC;
        background-color: #FFFFFF;
        margin: auto;
        margin-top: 5%px;
        padding: 100px;
        border-radius: 25px;
    }
    input[type=text], input[type=password] {
    width: 100%;
    padding: 12px 20px;
    margin: 8px 0;
    display: inline-block;
    border: 1px solid #ccc;
    box-sizing: border-box;
}
.login_btn{
    margin-left: 20%;
    margin-top: 50px;
    background: rgb(17, 0, 255);
    color: white;
}
.singin_btn{
    margin-left: 55%;
    margin-top: -50px;
    background: rgb(255, 136, 0);
}
button{
    padding: 20px;
    font-family: Montserrat-Bold;
    font-size: 15px;
    line-height: 1.5;
    text-transform: uppercase;
    width: 25%;
    height: 50px;
    border-radius: 25px;
    display: -webkit-box;
    display: -webkit-flex;
    display: -moz-box;
    display: -ms-flexbox;
    display: flex;
    justify-content: center;
    align-items: center;
    padding: 0 25px;
    -webkit-transition: all 0.4s;
    -o-transition: all 0.4s;
    -moz-transition: all 0.4s;
    transition: all 0.4s;
}
label{
    height: auto;
    width: auto;
    text-align: center;
    font-size: 45px;
    font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
}
</style>
